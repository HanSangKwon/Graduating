#pragma once
#include "stdafx.h"

class ChattingProcess : public ContentsProcess
{
public:
	ChattingProcess();
private:
	void registSubPacketFunc();

	static void C_REQ_REGIST_NAME(Session *session, Packet *rowPacket);	
	static void C_REQ_CHATTING(Session *session, Packet *rowPacket);
	static void C_REQ_CHAT_EXIT(Session *session, Packet *rowPacket);
};