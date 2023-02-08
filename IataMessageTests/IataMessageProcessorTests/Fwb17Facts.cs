﻿using FluentResults;
using IataMessageProcessor.Formatters.TextMessages;
using IataMessageProcessor.Parsers.TextMessages;
using IataMessageStandard;
using Xunit;


namespace IataMessageProcessorFacts
{
    public class Fwb17Facts
    {
        private TextMessageParser parser;
        private TextMessageFormatter formatter;

        public Fwb17Facts()
        {
            parser = new TextMessageParser();
            formatter = new TextMessageFormatter();
        }

        [Fact]
        public void ParserAndFormat()
        {
            string fwb17OriginText = @"FWB/17
555-64264793SVOREN/T114K2380DG6
FLT/SU1244/01/SU1008/01
RTG/SVORU/AMSRU/LGG
SHP
NAM/T. ULSIDAS LTD.
ADR/105 VEER TAMAN ROAD
LOC/MUMBAI
/IN
CNE/4321
NAM/AMERICAN MOTORS
ADR/29 BAY JAMES ST
LOC/BLOOMINGTON/MN
/US/52601/TE/4653425
AGT/083 0041 0101/0830041/0101
/SCHENKER DEUTSCHLAND AG
/DUESSELDORF
SSR/SHIPPERS CERTIFICATION FOR LIVE ANIMALS ATTACHED
/DO NOT FEED BUT FRESH WATER TO BE PROVIDED
NFY
NAM/EXPOWESTRANS KRASNOPRESNENSKAYA
/NABEREZHNAYA 14 CODE 10129010
ADR/10129-241110-10025-2 MOSCOW
/CUSTOMS-CUSTOMS POST-VISTAVOCHNIJ-
LOC/MOSCOW/RUSSIA
/RU/127015/TE/74956626979
ACC/GEN/DSV AIR   SEA CO.  LTD
/GEN/8-9F  15F RAFFLES CITY CHANGNING
/GEN/OFFICE TOWER 3  NO.1193 CHANGNING
/GEN/SHANGHAI
/GEN/200051
/GEN/CHINA
CVD/USD//PP/NVD/5696.00/6346.00
RTD/1/P1/K2400/CU/W2000/R10000/T10000
/NG/ABRASIVE PASTE
/2/K120.01/CX/S3
/NU/P1C0037XX
/3/CE/W400/R3.25/T1300
/4/PNYC/CU/W1410/R5000/T5000
/5/CE/W990/R2.90/T2871
/6/W142
/7/NC/UN3528.RFL.PI 378
/8/NC/1 ENGINE X 950 KG
/9/NC/OVERPACK USED
/10/ND//CMT606-244-273/1
/11/NV/MC0.10
/12/NS/1
OTH/P/MYC1600.50SCC2667.50AWC13.00
/P/SCC70.00
/P/AWC13.00
/P/CGC10.00
/P/RAC360.00
/P/TEC47.04
PPD/VC45.7
/CT800.00
COL/WT10000
/OA20/CT10020
CER/JOHAN-HALFMANN.LTD
ISU/01OCT06/RIO INTERNACIONAL/SPEEDAIR SERVICES
OSI/SHIPPER SRITIFICATION FOR LIVE ANNVDIMAL NEEDED
/NO FOOD BUT FRESH WATER REQUIRED
CDC/RUB60/1047460.2/0/1047460.2
REF//FRA111020090112/AGT/STRECKTRANSPORTGE/FRA
COR/T1
COI///14.40
SII/13076800/XX
ARD/DLA-AFEX21.0019
SPH/OHG/MOW/DGR/ENG/PAX/RFL/AOG/DDX
NOM/F.H. BERTLING AB - TRUST/GOTEBORG
SRI/KKL.44/UUSSDF/QNZ01JUN0800
OPI/AO ALFA LAVAL POTOK
///B/C1001/MOS
OPI/AO ALFA LAVAL POTOK
///D/C1001/MOS
OPI/IWS
//101211020/TRK/IWS/AMS
OPI/MENZIES
//580-24650463/GHA/CTMENZIES/AMS
OPI/MENZIES2
/BHXFRBA/NO.4321098
OCI/GB/ISS/RA/001-011
///ED/0213
/US/AGT/A/12345678
//DNR/D/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/D/UN8901 ID8000
///L/DIPL
/IT/IMP/M/07IT9876AB88901235
";
            Result<object> rObject = parser.Parse(fwb17OriginText);
            Fwb17 fwb17 = rObject.ValueOrDefault as Fwb17;

            Assert.NotNull(fwb17);
            Assert.Empty(rObject.Errors);

            string fwb17TextActual = formatter.ToString(fwb17);

            Assert.Equal(fwb17OriginText, fwb17TextActual);
        }
    }
}
