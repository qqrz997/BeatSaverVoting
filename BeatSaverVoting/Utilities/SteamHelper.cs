﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Steamworks;
namespace BeatSaverVoting.Utilities
{
    public static class SteamHelper
    {
        public static HAuthTicket lastTicket;
        public static EResult lastTicketResult;

        public static Callback<GetAuthSessionTicketResponse_t> m_GetAuthSessionTicketResponse;
    }
}
