using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace VitrualTrader
{
    public interface ITradeProcessor
    {
        void ProcessTrades(Stream stream);
    }
}
