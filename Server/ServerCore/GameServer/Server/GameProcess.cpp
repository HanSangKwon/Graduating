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

	INSERT_PACKET_PROCESS(C_REQ_EXIT); // TODO + PacketData  in -> Position

}

//---------------------------------------------------------------//
//패킷 처리 정의


void GameProcess::C_REQ_EXIT(Session *session, Packet *rowPacket)
{

}

