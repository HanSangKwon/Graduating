// ChattingServer.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

class SystemReport : public Work
{
	void tick()
	{
		Monitoring &moniter = Monitoring::getInstance();
		SLog(const_cast<WCHAR*>(L"### cpu usage : %2.2f%%, memory usage : %uByte"), moniter.processCpuUsage(), moniter.processMemUsage());
	}
};

void serverProcess()
{
	shared_ptr<Server> server(new IOCPServer(new GameProcess()));
	SystemReport systemReport;
	const int MONITOR_REPORTING_SEC = 1;
	TaskManager::getInstance().add(&systemReport, MONITOR_REPORTING_SEC, TICK_INFINTY);
	if (!server->run()) {
		SLog(const_cast<WCHAR*>(L"! error: server start fail"));
		return;
	}
}


/*


속성페이지 ->  C/C++ -> 언어 -> 준수모드 -> 아니요 
*/
int _tmain(int argc, _TCHAR* argv[])
{
	shared_ptr<Thread> serverThread(new Thread(new thread_t(serverProcess), L"GameServer"));

	Sleep(10000);
	return 0;
}
