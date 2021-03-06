#pragma once
#include "stdafx.h"

#define CELLMANAGER(X) CellManager::getInstance().Find(X)


class GameProcess : public ContentsProcess
{
public:
	GameProcess();
private:
	void registSubPacketFunc();

	static void C_REQ_INTO_ROOM(Session *session, Packet *rowPacket);
	static void C_REQ_REGIST_NAME(Session *session, Packet *rowPacket);
	static void C_REQ_GAME_EXIT(Session *session, Packet *rowPacket);

};