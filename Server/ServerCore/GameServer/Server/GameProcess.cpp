#include "stdafx.h"
#include "GameProcess.h"

GameProcess::GameProcess()
{
	this->registSubPacketFunc();
}

void GameProcess::registSubPacketFunc()
{
#define INSERT_PACKET_PROCESS(type)  runFuncTable_.insert(make_pair(E_##type, &GameProcess::##type))

	// Enum ��Ŷ��  Packet Ÿ�԰� GameProcess �� �Լ��� ���� map�� �ִ´�.

	INSERT_PACKET_PROCESS(C_REQ_EXIT); // TODO + PacketData  in -> Position

}

//---------------------------------------------------------------//
//��Ŷ ó�� ����


void GameProcess::C_REQ_EXIT(Session *session, Packet *rowPacket)
{

}

