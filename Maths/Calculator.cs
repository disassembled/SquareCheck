namespace Maths
{
    public static class Calculator
    {
        public static Result Evaluate(string strNumber)
        {
            var result = new Result();

            if (string.IsNullOrWhiteSpace(strNumber))
                result.Message = "Enter a number";
            else if (strNumber.Contains("-") || strNumber.Contains("."))
                result.Message = "Number is not square";
            else if (Math.Sqrt(Convert.ToInt32(strNumber)) % 1 != 0)
                result.Message = "Number is not square";
            else
            {
                result.Message = "Number is square";
                result.IsSquare = true;
            }

            return result;
        }
    }
}