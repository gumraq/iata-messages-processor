using IataMessageStandard.Fsr1Parts;

namespace IataMessageStandard
{
    public class Fsr1
    {
        [Reference(1)]
        public StandardMessageIdentification StandardMessageIdentification { get; set; }

        [Reference(2)]
        public ConsignmentDetail ConsignmentDetail { get; set; }

        [Reference(3)]
        public List<FlightDetails> FlightDetails { get; set; }

        [Reference(4)]
        public OtherServiceInformation OtherServiceInformation { get; set; }
    }
}