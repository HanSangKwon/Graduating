#include "stdafx.h"
#include "GameProcess.h"

GameProcess::GameProcess()
{
	this->registSubPacketFunc();
}

void GameProcess::registSubPacketFunc()
{
#define INSERT_PACKET_PROCESS(type)  runFuncTable_.insert(make_pair(E_##type, &GameProcess::##type))

	// Enum 패킷에  Packet 타입과 GameProcess 의 함수를 매핑 map에 넣는다.

	
	INSERT_PACKET_PROCESS(C_REQ_REGIST_NAME); // TODO + PacketData  in -> Position
	INSERT_PACKET_PROCESS(C_REQ_INTO_ROOM);
	INSERT_PACKET_PROCESS(C_REQ_GAME_EXIT); // TODO + PacketData  in -> Position

}

//---------------------------------------------------------------//
//패킷 처리 정의

void GameProcess::C_REQ_REGIST_NAME(Session *session, Packet *rowPacket)
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

void GameProcess::C_REQ_INTO_ROOM(Session *session, Packet *rowPacket)
{
	PK_C_REQ_INTO_ROOM *packet = (PK_C_REQ_INTO_ROOM *)rowPacket;


	PK_S_ANS_INTO_ROOM packet_;
	packet_.roomNum = packet->roomNum;

	session->sendPacket(&packet_);
}



void GameProcess::C_REQ_GAME_EXIT(Session *session, Packet *rowPacket)
{

}

