#include "stdafx.h"
#include "GameProcess.h"

GameProcess::GameProcess()
{
	this->registSubPacketFunc();
}

void GameProcess::registSubPacketFunc()
{
#define INSERT_PACKET_PROCESS(type)		runFuncTable_.insert(make_pair(E_##type, &GameProcess::##type))


	INSERT_PACKET_PROCESS(C_REQ_EXIT);
}

//---------------------------------------------------------------//
//��Ŷ ó�� ����

void GameProcess::C_REQ_EXIT(Session *session, Packet *rowPacket)
{
	//Ŭ���̾�Ʈ read thread �� ������� �ֱ� ���� ó��
	PK_C_REQ_EXIT *packet = (PK_C_REQ_EXIT *)rowPacket;
	User *user = UserManager::getInstance().at(session->id());
	if (user == nullptr) {
		SLog(L"! not registed : %s", session->clientAddress().c_str());
		session->onClose();
		return;
	}
	UserManager::getInstance().remove(session->id());

	PK_S_ANS_EXIT ansPacket;
	SLog(L"* recv exit packet by [%s]", session->clientAddress().c_str());
	session->sendPacket(&ansPacket);
}