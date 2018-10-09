#pragma once
#include "stdafx.h"

class GameProcess : public ContentsProcess
{
public:
	GameProcess();
private:
	void registSubPacketFunc();

	static void C_REQ_EXIT(Session *session, Packet *rowPacket);
};