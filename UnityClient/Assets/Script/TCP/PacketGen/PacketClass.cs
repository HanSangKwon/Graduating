using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace UnityGame
{
    public class PK_C_REQ_EXIT : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_EXIT; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_EXIT; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_EXIT : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_EXIT; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_EXIT; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_CHAT_EXIT : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_CHAT_EXIT; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_CHAT_EXIT; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_CHATEXIT : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_CHATEXIT; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_CHATEXIT; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_GAME_EXIT : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_GAME_EXIT; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_GAME_EXIT; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_GAME_EXIT : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_GAME_EXIT; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_GAME_EXIT; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_NOTIFY_TERMINAL : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_I_NOTIFY_TERMINAL; }
        Int64 type() { return (Int64) PacketType.E_I_NOTIFY_TERMINAL; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_NOTIFY_HEARTBEAT : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_NOTIFY_HEARTBEAT; }
        Int64 type() { return (Int64) PacketType.E_C_NOTIFY_HEARTBEAT; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_ID_PW : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_ID_PW; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_ID_PW; }
        public string         id_;
        public string         password_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, id_);
            PacketUtil.encode(packet_, password_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            id_ = PacketUtil.decodestring(packet, ref offset);
            password_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_ID_PW_FAIL : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_ID_PW_FAIL; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_ID_PW_FAIL; }
        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_ID_PW_SUCCESS : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_ID_PW_SUCCESS; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_ID_PW_SUCCESS; }
        public string         ip_;
        public UInt32         port_;
        public string         name_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, ip_);
            PacketUtil.encode(packet_, port_);
            PacketUtil.encode(packet_, name_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            ip_ = PacketUtil.decodestring(packet, ref offset);
            port_ = PacketUtil.decodeUInt32(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_REQ_ID_PW : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_I_DB_REQ_ID_PW; }
        Int64 type() { return (Int64) PacketType.E_I_DB_REQ_ID_PW; }
        public UInt64         clientId_;
        public string         id_;
        public string         password_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, id_);
            PacketUtil.encode(packet_, password_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            id_ = PacketUtil.decodestring(packet, ref offset);
            password_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_ANS_ID_PW : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_I_DB_ANS_ID_PW; }
        Int64 type() { return (Int64) PacketType.E_I_DB_ANS_ID_PW; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;
        public Byte         result_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
            PacketUtil.encode(packet_, result_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_CHTTING_NOTIFY_ID : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_I_CHTTING_NOTIFY_ID; }
        Int64 type() { return (Int64) PacketType.E_I_CHTTING_NOTIFY_ID; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_REQ_LOAD_DATA : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_I_DB_REQ_LOAD_DATA; }
        Int64 type() { return (Int64) PacketType.E_I_DB_REQ_LOAD_DATA; }
        public UInt64         clientId_;
        public UInt64         oidAccountId_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, oidAccountId_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            oidAccountId_ = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_DB_ANS_PARSE_DATA : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_I_DB_ANS_PARSE_DATA; }
        Int64 type() { return (Int64) PacketType.E_I_DB_ANS_PARSE_DATA; }
        public UInt64         clientId_;
        public string         name_;
        public Byte         result_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, result_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_I_LOGIN_NOTIFY_ID_LOADED : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_I_LOGIN_NOTIFY_ID_LOADED; }
        Int64 type() { return (Int64) PacketType.E_I_LOGIN_NOTIFY_ID_LOADED; }
        public UInt64         clientId_;
        public string         name_;
        public Byte         result_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, clientId_);
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, result_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            clientId_ = PacketUtil.decodeUInt64(packet, ref offset);
            name_ = PacketUtil.decodestring(packet, ref offset);
            result_ = PacketUtil.decodeByte(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_REGIST_NAME : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_REGIST_NAME; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_REGIST_NAME; }
        public string         name_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_REGIST_NAME : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_REGIST_NAME; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_REGIST_NAME; }
        public string         name_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_CHATTING : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_CHATTING; }
        public string         text_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, text_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            text_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_CHATTING : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_CHATTING; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_CHATTING; }
        public string         name_;
        public string         text_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
            PacketUtil.encode(packet_, text_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
            text_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_ENTER_GAME : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_ENTER_GAME; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_ENTER_GAME; }
        public string         name_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_ENTER_GAME : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_ENTER_GAME; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_ENTER_GAME; }
        public string         name_;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, name_);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            name_ = PacketUtil.decodestring(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_C_REQ_INTO_ROOM : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_C_REQ_INTO_ROOM; }
        Int64 type() { return (Int64) PacketType.E_C_REQ_INTO_ROOM; }
        public UInt64         roomNum;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, roomNum);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            roomNum = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
    public class PK_S_ANS_INTO_ROOM : PacketData, PacketInterface
    {
        Int64 PacketInterface.type() { return (Int64) PacketType.E_S_ANS_INTO_ROOM; }
        Int64 type() { return (Int64) PacketType.E_S_ANS_INTO_ROOM; }
        public UInt64         roomNum;

        void PacketInterface.encode()
        {
            PacketUtil.encodeHeader(packet_, this.type());
            PacketUtil.encode(packet_, roomNum);
        }
        void PacketInterface.decode(byte[] packet, ref int offset)
        { 
            roomNum = PacketUtil.decodeUInt64(packet, ref offset);
        }
        MemoryStream PacketInterface.getStream()
        {
            return packet_;
        }
    }
}
