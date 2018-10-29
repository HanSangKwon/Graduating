#pragma once
#include "stdafx.h"

#define PACKET_MAKE_DATE "2015/03/14 13:14:41" 
enum PacketType : Int64 {
    /*128*/    E_C_REQ_EXIT = 128,
    /*129*/    E_S_ANS_EXIT = 129,
    /*130*/    E_C_REQ_CHAT_EXIT = 130,
    /*131*/    E_S_ANS_CHATEXIT = 131,
    /*132*/    E_C_REQ_GAME_EXIT = 132,
    /*133*/    E_S_ANS_GAME_EXIT = 133,
    /*134*/    E_I_NOTIFY_TERMINAL = 134,
    /*135*/    E_C_NOTIFY_HEARTBEAT = 135,
    /*136*/    E_C_REQ_ID_PW = 136,
    /*137*/    E_S_ANS_ID_PW_FAIL = 137,
    /*138*/    E_S_ANS_ID_PW_SUCCESS = 138,
    /*139*/    E_I_DB_REQ_ID_PW = 139,
    /*140*/    E_I_DB_ANS_ID_PW = 140,
    /*141*/    E_I_CHTTING_NOTIFY_ID = 141,
    /*142*/    E_I_DB_REQ_LOAD_DATA = 142,
    /*143*/    E_I_DB_ANS_PARSE_DATA = 143,
    /*144*/    E_I_LOGIN_NOTIFY_ID_LOADED = 144,
    /*145*/    E_C_REQ_REGIST_NAME = 145,
    /*146*/    E_S_ANS_REGIST_NAME = 146,
    /*147*/    E_C_REQ_CHATTING = 147,
    /*148*/    E_S_ANS_CHATTING = 148,
    /*149*/    E_C_REQ_ENTER_GAME = 149,
    /*150*/    E_S_ANS_ENTER_GAME = 150,
    /*151*/    E_C_REQ_INTO_ROOM = 151,
    /*152*/    E_S_ANS_INTO_ROOM = 152,
};
