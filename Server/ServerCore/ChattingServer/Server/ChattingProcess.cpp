#include "stdafx.h"
#include "ChattingProcess.h"

ChattingProcess::ChattingProcess()
{
	this->registSubPacketFunc();
}

void ChattingProcess::registSubPacketFunc()
{
#define INSERT_PACKET_PROCESS(type)		runFuncTable_.insert(make_pair(E_##type, &ChattingProcess::##type))

	INSERT_PACKET_PROCESS(C_REQ_REGIST_NAME);
	INSERT_PACKET_PROCESS(C_REQ_CHATTING);
	INSERT_PACKET_PROCESS(C_REQ_CHAT_EXIT);

}

//---------------------------------------------------------------//
//패킷 처리 정의


void ChattingProcess::C_REQ_REGIST_NAME(Session *session, Packet *rowPacket)
{

	SLog(L" <session id> : %d", session->id());
	//클라이언트 read thread 를 종료시켜 주기 위해 처리
	PK_C_REQ_REGIST_NAME *packet = (PK_C_REQ_REGIST_NAME *)rowPacket;


	User *user = UserManager::getInstance().Find(session->id());
	if (user != nullptr) {
		SLog(L"! not registed : %s", session->clientAddress().c_str());
		session->onClose();
		return;
	}
	else

	user = new User(session);
	array<WCHAR, SIZE_64> userName;
	StrConvA2W((CHAR *)packet->name_.c_str(), userName.data(), userName.size());
	user->setName(userName.data());
	UserManager::getInstance().insert(user);

	SLog(L" <C_REQ_REGIST_NAME> userpoolsize  : %d", UserManager::getInstance().size());

	PK_S_ANS_REGIST_NAME packet_;

}

void ChattingProcess::C_REQ_CHATTING(Session *session, Packet *rowPacket)
{
	PK_C_REQ_CHATTING *packet = (PK_C_REQ_CHATTING *)rowPacket;

	User *user = UserManager::getInstance().at(session->id());


	if (user == nullptr) {
		SLog(L"! not registed : %s", session->clientAddress().c_str());
		session->onClose();
		return;
	}

	PK_S_ANS_CHATTING retPacket;
	array<char, SIZE_64> name;
	StrConvW2A((WCHAR *)user->name().c_str(), name.data(), name.size());
	retPacket.name_ = name.data(); 
	retPacket.text_ = " : ";
	retPacket.text_ += packet->text_;


	for (auto it : UserManager::getInstance().userPool_) {
		SLog(L"* send message %S, %S", retPacket.name_.c_str(), retPacket.text_.c_str());
		if (it.second != user) {
			it.second->session()->sendPacket(&retPacket);
		}
	}

}


void ChattingProcess::C_REQ_CHAT_EXIT(Session *session, Packet *rowPacket)
{

	SLog(L" <session id> : %d", session->id());
	//클라이언트 read thread 를 종료시켜 주기 위해 처리
	PK_C_REQ_CHAT_EXIT *packet = (PK_C_REQ_CHAT_EXIT *)rowPacket;
	//User *user = UserManager::getInstance().Find(session->id());
	//if (user == nullptr) {
	//	SLog(L"! not registed : %s", session->clientAddress().c_str());
	//	session->onClose(); 
	//	return;
	//}
	UserManager::getInstance().remove(session->id());
	session->onClose();
	SLog(L" <C_REQ_CHAT_EXIT> userpoolsize  : %d", UserManager::getInstance().size());

	SLog(L"* recv exit packet by [%s]", session->clientAddress().c_str());
}