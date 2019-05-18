﻿namespace D2NG.BNCS.Packet
{
    public enum Sid : byte
    {
        NULL = 0x00,
        STOPADV = 0x02,
        SERVERLIST = 0x04,
        CLIENTID = 0x05,
        STARTVERSIONING = 0x06,
        REPORTVERSION = 0x07,
        STARTADVEX = 0x08,
        GETADVLISTEX = 0x09,
        ENTERCHAT = 0x0A,
        GETCHANNELLIST = 0x0B,
        JOINCHANNEL = 0x0C,
        CHATCOMMAND = 0x0E,
        CHATEVENT = 0x0F,
        LEAVECHAT = 0x10,
        LOCALEINFO = 0x12,
        FLOODDETECTED = 0x13,
        UDPPINGRESPONSE = 0x14,
        CHECKAD = 0x15,
        CLICKAD = 0x16,
        READMEMORY = 0x17,
        REGISTRY = 0x18,
        MESSAGEBOX = 0x19,
        STARTADVEX2 = 0x1A,
        GAMEDATAADDRESS = 0x1B,
        STARTADVEX3 = 0x1C,
        LOGONCHALLENGEEX = 0x1D,
        CLIENTID2 = 0x1E,
        LEAVEGAME = 0x1F,
        ANNOUNCEMENT = 0x20,
        DISPLAYAD = 0x21,
        NOTIFYJOIN = 0x22,
        WRITECOOKIE = 0x23,
        READCOOKIE = 0x24,
        PING = 0x25,
        READUSERDATA = 0x26,
        WRITEUSERDATA = 0x27,
        LOGONCHALLENGE = 0x28,
        LOGONRESPONSE = 0x29,
        CREATEACCOUNT = 0x2A,
        SYSTEMINFO = 0x2B,
        GAMERESULT = 0x2C,
        GETICONDATA = 0x2D,
        GETLADDERDATA = 0x2E,
        FINDLADDERUSER = 0x2F,
        CDKEY = 0x30,
        CHANGEPASSWORD = 0x31,
        CHECKDATAFILE = 0x32,
        GETFILETIME = 0x33,
        QUERYREALMS = 0x34,
        PROFILE = 0x35,
        CDKEY2 = 0x36,
        UNKNOWN_37 = 0x37,
        UNKNOWN_39 = 0x39,
        LOGONRESPONSE2 = 0x3A,
        CHECKDATAFILE2 = 0x3C,
        CREATEACCOUNT2 = 0x3D,
        LOGONREALMEX = 0x3E,
        STARTVERSIONING2 = 0x3F,
        QUERYREALMS2 = 0x40,
        QUERYADURL = 0x41,
        CDKEY3 = 0x42,
        WARCRAFTUNKNOWN = 0x43,
        NETGAMEPORT = 0x45,
        NEWS_INFO = 0x46,
        OPTIONALWORK = 0x4A,
        EXTRAWORK = 0x4B,
        REQUIREDWORK = 0x4C,
        TOURNAMENT = 0x4E,
        AUTH_INFO = 0x50,
        AUTH_CHECK = 0x51,
        AUTH_ACCOUNTCREATE = 0x52,
        AUTH_ACCOUNTLOGON = 0x53,
        AUTH_ACCOUNTLOGONPROOF = 0x54,
        AUTH_ACCOUNTCHANGE = 0x55,
        AUTH_ACCOUNTCHANGEPROOF = 0x56,
        AUTH_ACCOUNTUPGRADE = 0x57,
        AUTH_ACCOUNTUPGRADEPROOF = 0x58,
        SETEMAIL = 0x59,
        RESETPASSWORD = 0x5A,
        CHANGEEMAIL = 0x5B,
        SWITCHPRODUCT = 0x5C,
        REPORTCRASH = 0x5D,
        WARDEN = 0x5E,
        GAMEPLAYERSEARCH = 0x60,
        FRIENDSLIST = 0x65,
        FRIENDSUPDATE = 0x66,
        FRIENDSADD = 0x67,
        FRIENDSREMOVE = 0x68,
        FRIENDSPOSITION = 0x69,
        CLANFINDCANDIDATES = 0x70,
        CLANINVITEMULTIPLE = 0x71,
        CLANCREATIONINVITATION = 0x72,
        CLANDISBAND = 0x73,
        CLANMAKECHIEFTAIN = 0x74,
        CLANINFO = 0x75,
        CLANQUITNOTIFY = 0x76,
        CLANINVITATION = 0x77,
        CLANREMOVEMEMBER = 0x78,
        CLANINVITATIONRESPONSE = 0x79,
        CLANRANKCHANGE = 0x7A,
        CLANSETMOTD = 0x7B,
        CLANMOTD = 0x7C,
        CLANMEMBERLIST = 0x7D,
        CLANMEMBERREMOVED = 0x7E,
        CLANMEMBERSTATUSCHANGE = 0x7F,
        CLANMEMBERRANKCHANGE = 0x81,
        CLANMEMBERINFORMATION = 0x82
    }
}
