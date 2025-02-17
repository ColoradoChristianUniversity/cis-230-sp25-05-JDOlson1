namespace Client.Library;

public class Calculator : ICalculator
{
    public float Add(float a, params float[] b)
    {
        if (float.IsNaN(a) || float.IsInfinity(a))
        {
            throw new ArgumentOutOfRangeException(nameof(a), "Input cannot be NaN or Infinity.");
        }

        foreach (float num in b)
        {
            if (float.IsNaN(num) || float.IsInfinity(num))
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Input cannot be NaN or Infinity.");
            }
        }

        float sum = a;
        foreach (float num in b)
        {
            sum += num;
        }
        return sum;
    }



    public float Divide(float a, params float[] b)
    {
        if (float.IsNaN(a) || float.IsInfinity(a))
        {
            throw new ArgumentOutOfRangeException(nameof(a), "Input cannot be NaN or Infinity.");
        }

        foreach (float num in b)
        {
            if (float.IsNaN(num) || float.IsInfinity(num))
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Input cannot be NaN or Infinity.");
            }
            if (num == 0)
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Cannot divide by zero.");
            }
        }

        float result = a;

        foreach (float num in b)
        {
            result /= num;
        }

        return result;
    }

    public float Modulus(float a, float b)
    {
        if (b == 0f || float.IsNaN(a) || float.IsNaN(b) || float.IsInfinity(a) || float.IsInfinity(b))
        {
            throw new ArgumentOutOfRangeException("Invalid input for modulus operation.");
        }
        return a % b;
    }


    public float Multiply(float a, params float[] b)
    {
        if (float.IsNaN(a) || float.IsInfinity(a))
        {
            throw new ArgumentOutOfRangeException(nameof(a), "Input cannot be NaN or Infinity.");
        }

        foreach (float num in b)
        {
            if (float.IsNaN(num) || float.IsInfinity(num))
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Input cannot be NaN or Infinity.");
            }
        }

        float result = a;

        foreach (float num in b)
        {
            result *= num;
        }

        return result;
    }

    public float Power(float baseValue, float exponent)
    {
        if (float.IsNaN(baseValue) || float.IsInfinity(baseValue))
        {
            throw new ArgumentOutOfRangeException(nameof(baseValue), "Base value cannot be NaN or Infinity.");
        }

        return (float)Math.Pow(baseValue, exponent);
    }

    public float SquareRoot(float number)
    {
        if (number < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(number), "Cannot calculate square root of a negative number.");
        }
        return (float)Math.Sqrt(number);
    }

    public float Subtract(float a, params float[] b)
    {
        if (float.IsNaN(a) || float.IsInfinity(a))
        {
            throw new ArgumentOutOfRangeException(nameof(a), "Input cannot be NaN or Infinity.");
        }

        foreach (float num in b)
        {
            if (float.IsNaN(num) || float.IsInfinity(num))
            {
                throw new ArgumentOutOfRangeException(nameof(b), "Input cannot be NaN or Infinity.");
            }
        }

        float result = a;
        foreach (float num in b)
        {
            result -= num;
        }
        return result;
    }
}