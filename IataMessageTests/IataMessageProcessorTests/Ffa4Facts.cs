﻿using FluentResults;
using IataMessageProcessor.Formatters.TextMessages;
using IataMessageProcessor.Parsers.TextMessages;
using IataMessageStandard;
using Xunit;


namespace IataMessageProcessorFacts
{
    public class Ffa4Facts
    {
        private TextMessageParser parser;
        private TextMessageFormatter formatter;

        public Ffa4Facts()
        {
            parser = new TextMessageParser();
            formatter = new TextMessageFormatter();
        }

        [Fact]
        public void Fsa15ParserTests1()
        {
            string fsa15Text = @"FSA/15
157-72071554PENSVO/T10K4044.0
RCS/02JAN1403/ALA/T6K150/UTEGENOV SERIK
/MC2.96
RCS/02JAN1659/SVO/T1K0.2
RCS/13MAY1017/BKK/T809K5095.0/NA
RCT/MI/23MAR1813/HKT/T148K1645.2
/SU/AERODAR
RCT/RU/30OCT1014/SIN/T10K263
/SU
RCT/RU/17OCT2034/ORD/T1K12.2
RCF/SU2428/03MAY0015-N/BLQ/T2600K22057
RCF/SU270/04NOV2002/BKK/T4K29.0//A2000
RCF/RU791/04OCT0600-N/NRT/P137K2441.5/A0515/A2015
RCF/N4201/05NOV0519/PEE/T3K37
RCF/SU8989/16APR2346/CPH/T149K3495//S2330
BKD/RU8105/09AUG/FRAVIE/T1151K10006/S2359/S0800-S/MC127.84
BKD/SU270/15SEP/SVOBKK/T8K66.0/A0900/E2220
BKD/P35070/21SEP/AMSOVB/T19K7435/E1000-N/E0003-S/MC1.00
BKD/TX9806/09NOV/BKKSVO/T1460K26274///MC10.00
BKD/TX9806/09NOV/BKKSVO/T1460K26274//E0003/MC10.00
BKD/TX9806/09NOV/BKKSVO/T1460K26274
MAN/KC875/18MAR/ALADME/T11K110.4/S1855-P/S2350
MAN/SU2131/19FEB/ISTPEK/T5/S1456/S1726
MAN/RU7771B/12OCT/LHRAMS/T9K1390
MAN/SU2982/25SEP/LEDVVO/T1K23/S1715
DEP/SU2137/30APR/ISTROV/T2//E0230
DEP/SU001/05MAY/OSLHEL/T140K3370/A0940/S1000-N
DEP/SU2137/11MAY/ISTKUF/T8/A1529/E1759
DEP/HZ5616/13MAY/VVOPKC/T138K944
DEP/SU001/18AUG/OSLHEL/T81K1846/A1100/S0600-N
DEP/RU339/13OCT/SINHKG/T48K454/A0415-N/A0745-N
DEP/RU2065/01OCT/SEAORD/T11K923/A2200/A0800-T
PRE/RU6227/28OCT/CDGFRA/T1K5/S2010/E2000
PRE/RU560/30OCT/LGGDME/T1K38/E0230-N/E0620-N
TRM/AF/CPH/T6K166
TRM/AF/CPH/T3K25.5
TFD/SU/12DEC1713/GVA/P100K1008/768347
TFD/SU/21JAN1713/BKK/T33K349.0/045491
/SU
TFD/SU/05AUG1713/BKK/T83K1339.0/042019
/SU/AFL-LOGISTIC
NFD/03JUN0942/JFK/T44
NFD/02MAR1713/IAD/T1K28/OLD DOMINION FREIGHT LINE INC.
AWD/05MAY1926/KUF/T1K2/GADZHIEV AI
CCD/30JAN1739/MIA/T136K1600
CCD/21JAN1950/MIA/T1
ULD/PMC16735QR/PMC91281FF/PMC15825QR
DLV/04MAR2142/ALA/T1K4
DLV/05MAR1950/KHV/T12K127/POLOVKOV N.V.
DIS/SU1602/27MAR1950/KUF/DFLD/T4K15.2
ULD/PAG77151SU/PAG77091SU/AKE37670SU/AKE35949SU/PAG69290SU
DIS/SU502/27MAR1927/TLV/FDCA/P4K862.9
DIS//26MAR0911/ARN/FDCA/T1K0.7
OSI/VIOLATION OF PACKAGING
CRC/26MAR0911/SVO/T45///LGGDME
DDL/05MAR0911/KHV/T12K127/POLOVKOV N.V.
OSI/VIOLATION OF PACKAGING
TGC/21JAN1950/MIA/T1
ULD/PMC16735QR/PMC91281FF/PMC15825QR
ARR//28MAY2050-P/PEE/T1/A0000/A2050
ARR/SU010/29SEP0933/LED/P4K54//A0933
ARR/HZ5629/01JAN1909/KHV/T1/A0000/A1909
ARR/SU1421/01JAN1334/SVO/T1K1.2
AWR/SU2040/29JUL1235/ZAG/T8//A1210
AWR/SU2034/17DEC1413-T/OTP/T2//A1205
AWR/FV6527/22DEC1257/SOF/T150K2011.0
AWR/SU044/20OCT0003/LED/T1K17/A1205/A0003-N
FOH/04JUN1601/LED/T42K119.605/FGUP POCHTA ROSSII
/MC0.031
FOH/05MAR2038/MAD/T1K276/KUEHNE  NAGEL S.A.
OCI/IE/OSS/RC/QADOH-QR
/MY/ISS/RA/00001-01
/MY//SS/SPX
/MY//SS/SPX
/MY//SM/XRY
/MY//SM/XRY
/MY//SN/NIKARIESANIKHARIS
/MY//SN/NORHAILIZAMOHD RADZI
/MY//SD/01-DEC-2021 2047
/MY//SD/02-DEC-2021 1507
/MY//ED/0522
";
            Result<object> rObject = parser.Parse(fsa15Text);
            Assert.NotNull(rObject);
            var fsa15 = rObject.ToResult(o => (Fsa15)o);

            var fsa15TextActual = formatter.ToString(fsa15.Value);

            Assert.Equal(fsa15Text, fsa15TextActual);
        }

        [Fact]
        public void Fhl5ParserTests1()
        {
            string fhl5Text = @"FHL/5
MBI/618-12345675SINJFK/T7K1000
HBS/AEI12345678/SINJFK/1/K400/4/COMPUTER PARTS
TXT/MODEL 3 MEMORY BOARDS AND OTHER ASSORTED PARTS
OCI/GB/ISS/RA/001-011
///ED/0213
/US/AGT/A/12345678
//DNR/D/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/D/UN8901 ID8000
///L/DIPL
/IT/IMP/M/07IT9876AB88901235
HBS/22AA12121212/FRAJFK/200/K1800//BOLTS
HBS/00000002/SVOPVG/176/K10783.00//SPUNBOND NONWOVEN MATERIALS
TXT/CNENAME2-TRADING DEVELOPMENT CO. LTDSHPNAME2-PLANT JOINT STOCK C
/SPARE PARTS
/MEASURING EQUIPMENT  ACCESSORIESS2006-172VOL 0.002 M3DIMS 1  46 X
HBS/51791876/SVOSTR/1/K9.25//ISIS C2 INTRAOPERATIVE NERVE
HBS/U182306/SVOFCO/1/K85/1/HUMAN BLOOD
/NSC/ICE
TXT/HUMAN BLOOD UN3373  CAT.B DRY ICE UN1845 1 20 KG DIMS 79X53X58 CM
/ X 1 HS CODE  3002120005       1 SLAC
HTS/3002120005
OCI/RU/SHP/CT/74956443414
/IT/NFY/CT/3906650431
/RU/DNR/D/1845B
SHP
NAM/AMERICAN MOTORS
ADR/29 BAY JAMES ST
LOC/BLOOMINGTON/MN
/US/52601/TE/4653425
CNE
NAM/AIE EXPRESS INTL
ADR/CENTRAL STREET 13
LOC/JAMAICA/NY
/US/22330/TE/171812344566
CVD/USD/PP/NVD/5696.00/6346.00
";
            Result<object> rObject = parser.Parse(fhl5Text);
            Assert.NotNull(rObject);
            var fhl5 = rObject.ToResult(o => (Fhl5)o);

            var fhl5TextActual = formatter.ToString(fhl5.Value);

            Assert.Equal(fhl5Text, fhl5TextActual);
        }


        [Fact]
        public void Fbr2ParserTests1()
        {
            string fbr2Text = @"FBR/2
FLT/KL775/09FEB/ZRH
REF//FRA111020090112/AGT/STRECKTRANSPORTGE/FRA
";
            Result<object> rObject = parser.Parse(fbr2Text);
            Assert.NotNull(rObject);
            Result<Fbr2> fbr2 = rObject.ToResult(o => (Fbr2)o);

            string fblTextActual = formatter.ToString(fbr2.Value);

            Assert.Equal(fbr2Text, fblTextActual);
        }

        [Fact]
        public void Fbl4ParserTests1()
        {
            string fbl4TextOrigin = @"FBL/4
1/KL775/09FEB/ZRH/HB-IHA
LIS/NIL
CCS
235-59889885SVOHKG/T12K25.9MC0.15/INTEGRATED CIRC
DIM/K0/CMT30-30-13/11
/K0/CMT44-26-17/1
/KVAZAR
555-51810426SVOIKA/T1K175MC0.12/RADIOACTIVE MAT
/470/GSP/471/RRY/PIL
/GSP DGP SU/E
SSR/SPECIALIZED DGR
/SSR3
OSI/ID 1437663181  HS 2844
/HALF-LIFE 8 DAYS  NO DELAY
555-20506555VVONBC/T10K194.4MC1.30/MASKI
ULD/2/PKC10056SU/K178.3/PKC12168SU/K89.1
555-27902932FRASVO/T1K3.8MC0.04/DATA LOADER  CI
/SVC
DIM/K0/CMT40-30-30/1
/LUFTHANSA TECHNIK/S
SSR/INVOICE ATTACHED TO AWB
/OWN
OSI/SPX KC DERA00777-05
OCI/DE/ISS/RA/00777-05
///ED/0521
///SN/BARBARA KLICH
///SD/06FEB210711
/DE/EXP/M/21DE330243450436E8
/DE/EXP/M/AT-ZLATE7100127002202133021
/DE/SHP/T/EUROPEAN VAT NUMBER DE811715450
/DE/SHP/CP/CUSTOMER SERVICE FRA
/DE/SHP/CT/496969647077
555-58195303ZAGMIA/T3K267.4MC2.88/CONSOLIDATION A
/460/CRT/EAP
DIM/K0/CMT120-80-100/3
/EURO-RUTA D.O.O./SU2041/12FEB/ZAG/X
ULD/2/PKC10056SU/K178.3/PKC12168SU/K89.1
SSR/3CLL MARKED AND ADDRESSED DOCUMENTS ATTACHED TO AWB TRANSPORT AN
/D STORAGE TEMPERATURE BETWEEN 15C AND 25C WHENEVER POSSIBLE EMERG
074-69123473ZRHCCS/T12K950DG9/BANKNOTES
/VAL
/ALFA AIR AGENCY/X
074-77184387ZRHMUN/P1K4DG4T12/SPARES
/EMERY
125-77184464ROMCCS/T123K12444MC94.4/CHEM LIQUID
/RFL
//SR917/07FEB/AMS/L
CUR
074-88241152ZRHCUR/T1K830MC1.2/MACHINERY
/HEA/MAG
OSI/CFM THAT SPECIAL TRUCK MUST BE USED TO
/MOVE THIS SHIPMENT
LIM
074-22221112ZRHLIM/T12K144DG4/MEDICINES
/PER
SSR/KEEP COOL STORE AT MINUS 2 DEGREES
/GENERAL
OCI///ST/DSV AIR SEA CO. LTD. CN1 HAS
/DE/EXP/M/20DE880426281976E0
/IT/SHP/T/EUROPEAN VAT NUMBERITIT00748210150
LAST
";
            Result<object> rObject = parser.Parse(fbl4TextOrigin);
            Assert.NotNull(rObject);
            var fbl4 = rObject.ToResult(o => (Fbl4)o);

            string fbl4TextActual = formatter.ToString(fbl4.Value);

            Assert.Equal(fbl4TextOrigin, fbl4TextActual);
        }

        [Fact]
        public void Ffm8ParserTests1()
        {
            string ffm8OriginText = @"FFM/8
1/SU1145/01JAN0400/AAQ/VPBLN/RU/01JAN0555/SVO
SVO/24JUL1105/24JUL1300
074-12345632HAMAMS/T4K8MC0.16/VIDEO CASSETTES
/COL/RFL/PIL
DIM/K25.5/CMT69-68-70/1
/K15/CMT29-80-47/2
/YYZKL667/19MAR
/TAORU
/G
OSI/OSI EML-NEAPOLIT JINR.RU   TO  SII - SHEREMETYEVO CARGO J.S.C.
/HANDLE WITH CARE  DO NOT TILT MORE THAN 40 DEGREES
COR/X
OCI/GB/ISS/RA/001-011
///ED/0213
/US/AGT/AR/12345678
//DNR/DR/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/DR/UN8901 ID8000
///LR/DIPL
/IT/IMP/MH/07IT9876AB88901235
074-12345641HAMYYZ/T15K160MC0.27/WATCHES
/YYZKL667/19MAR
074-12345653HAMAMS/T3K41MC0.2/COMP TERMINALS
074-12345653HAMAMS/T1K1MC0.01/NEWSFILM
OCI/GB/ISS/RA/001-011
///ED/0213
/US/ISS/AR/12345678
//DNR/DR/UN1234 UN2345 UN3456 UN4567 UN6789
//DNR/DR/UN8901 ID8000
///LR/DIPL
/IT/IMP/MG/07IT9876AB88901235
ULD/P1G1234KL-M/HT270WT1658.0ENT
/LISIB785/19MAR
/2
074-12345664HAMLIS/T200K500MC0.53/DIAGNOST.TEST
074-12345653HAMLIS/T4K10MC0.06/PRESSURE GAUGES
OSI/OSI EML-NEAPOLIT JINR.RU   TO  SII - SHEREMETYEVO CARGO J.S.C.
/HANDLE WITH CARE  DO NOT TILT MORE THAN 40 DEGREES
074-12345686TYOLIS/T3K300MC1.36/RADIOS
COR/T1
ULD/AVM9243KL
074-12345690HAMAMS/T60K900MC2.25/MACHINE PARTS
RTM
074-35775331HAMRTM/T1K72MC0.6/PURSES
OSI/CTC CNE PRIOR TO ARRIVAL
/DUE TO URGENCE OF DISTRIBUTION
074-67534415HAMRTM/T10K50MC0.15/BOOKS
COR/C
ULD/AVM9876KL
074-53153155HAMRTM/T100K1200MC3/MAGAZINES
LAST
";
            Result<object> rObject = parser.Parse(ffm8OriginText);
            Assert.NotNull(rObject);
            Result<Ffm8> ffm8 = rObject.ToResult(o => (Ffm8)o);

            string ffm8ActualText = formatter.ToString(ffm8.Value);

            Assert.Equal(ffm8OriginText, ffm8ActualText);
        }

        [Fact]
        public void Fwb17ParserTests()
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
            Assert.NotNull(rObject);
            var fwb17 = rObject.ToResult(o => (Fwb17)o);

            string fwb17ActualText = formatter.ToString(fwb17.Value);

            Assert.Equal(fwb17OriginText, fwb17ActualText);
        }

        [Fact]
        public void Ffa4ParserTests()
        {
            string ffa4OriginText = @"FFA/4
555-29681396SVOKHV/T286K878MC0.4/KOSMETIKA
/470/471/RMD
SU1712/03NOV/SVOKHV/KK
SU2301/31DEC/FRASVO/KK
SU270/01JAN/SVOBKK/KK
SSR/SPECIALIZED DGR
/DANGEROUS GOODS AS PER ATTACHED SHIPPER S DECLARATION
OSI/NOT SECURED
REF//FRA111020090112/AGT/STRECKTRANSPORTGE/FRA
";
            Result<object> rObject = parser.Parse(ffa4OriginText);
            Assert.NotNull(rObject);
            var ffa4 = rObject.ToResult(o => (Ffa4)o);

            string ffa4ActualText = formatter.ToString(ffa4.Value);

            Assert.Equal(ffa4OriginText, ffa4ActualText);
        }

        [Fact]
        public void FsrParserTests()
        {
            string fsrOriginText = @"FSR
057-12345675CDGLAX/T10K500/BOOKS
AF099/20MAR/CDGJFK
AA1234/22MAR/JFKLAX
SU//JFKLAX
OSI/CONSIGNEE IS LOOKING FOR THE TENTH PIECE
/SAFE TO -6 DEGREE
";
            Result<object> rObject = parser.Parse(fsrOriginText);
            Assert.NotNull(rObject);
            var fsr = rObject.ToResult(o => (Fsr)o);

            string fsrActualText = formatter.ToString(fsr.Value);

            Assert.Equal(fsrOriginText, fsrActualText);
        }
    }
}
