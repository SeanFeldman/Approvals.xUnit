namespace Tests
{
    using Approvals.xUnit;
    using Xunit;

    public class ApproverTests
    {
        [Fact]
        public void Can_Approve_Text()
        {
            Approver.Verify("Text to\r\napprove");
        }

        [Fact]
        public void Can_Approve_Text_With_Scenario()
        {
            Approver.Verify("Text to\r\napprove", scenario: "test");
        }

        [Fact]
        public void Can_Approve_Text_With_Scrubber()
        {
            Approver.Verify("Text to approve", s => s.Replace("approve", "replace"));
        }

        [Fact]
        public void Can_Approve_Object()
        {
            var sample = new Sample { Value1 = "Value", Value2 = 42 };

            Approver.Verify(sample);
        }

        [Fact]
        public void Can_Approve_Object_With_Scenario()
        {
            var sample = new Sample { Value1 = "Value", Value2 = 42 };

            Approver.Verify(sample, scenario: "test");
        }

        [Fact]
        public void Can_Approve_Object_With_Scrubber()
        {
            var sample = new Sample { Value1 = "Value", Value2 = 42 };

            Approver.Verify(sample, s => s.Replace("42", "100"));
        }
    }

    class Sample
    {
        public string Value1 { get; set; }

        public int Value2 { get; set; }
    }
}
