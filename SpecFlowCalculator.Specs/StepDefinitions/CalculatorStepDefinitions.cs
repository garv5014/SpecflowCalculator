namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly Calculator _calculator = new Calculator();
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        private int _result;

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
           _result = _calculator.Sub();
        }

        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
           _result = _calculator.Mul();
        }

        [When(@"operation \+ is done to the number (.*)")]
        public void WhenPlusIsDoneToTheNumber(int p0)
        {
            _result = _calculator.Plus(p0);

        }
        [When(@"operation \/ is done to the number (.*)")]
        public void WhenDivIsDoneToTheNumber(int p0)
        {
            _result = _calculator.Div(p0);

        }
        [When(@"operation \% is done to the number (.*)")]
        public void WhenModIsDoneToTheNumber(int p0)
        {
            _result = _calculator.Mod(p0);

        }

        [When(@"operation \- is done to the number (.*)")]
        public void WhenSubIsDoneToTheNumber(int p0)
        {
            _result = _calculator.Minus(p0);

        }






        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _result.Should().Be(result);
        }
    }
}