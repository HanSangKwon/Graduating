#pragma once
#include "stdafx.h"

#define _terminal			TerminalManager::getInstance()

// �ٸ� �������� ������ ���� ���
class TerminalManager : public Singleton<TerminalManager>
{
	unordered_map<wstr_t, Terminal*> terminalPool_;
	Server						*server_;

public:
	TerminalManager();
	virtual ~TerminalManager();

	void initialize(xml_t *config);

	void put(wstr_t serverName, Terminal *terminal);
	Terminal* get(wstr_t name);
	
	bool isTerminal(const char *ip);
	void run(Server *server);
};