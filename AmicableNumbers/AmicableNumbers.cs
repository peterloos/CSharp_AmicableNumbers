using System;
using System.Text;

class AmicableNumbers
{
    private long start;
    private long end;
    private long[] numbers;

    public AmicableNumbers()
    {
        this.start = 1;
        this.end = 1000;
        this.numbers = new long[0];
    }

    public long Start
    {
        get
        {
            return this.start;
        }

        set
        {
            this.start = value;
        }
    }

    public long End
    {
        get
        {
            return this.end;
        }

        set
        {
            this.end = value;
        }
    }

    public long[] Numbers
    {
        get
        {
            return (long[])this.numbers.Clone();
        }
    }

    private long SumOfDivisors(long value)
    {
        long result = 0;
        long half_value = value / 2;

        for (long i = 1; i <= half_value; i++)
        {

            if (value % i == 0)
            {
                result += i;
            }
        }

        return result;
    }

    private void AddNumber(long value)
    {
        long[] tmp = new long[this.numbers.Length + 1];

        for (int i = 0; i < this.numbers.Length; i ++)
            tmp[i] = this.numbers[i];

        tmp[this.numbers.Length] = value;

        this.numbers = tmp;
    }

    public void Calculate()
    {
        // clear old calculation, if any
        this.numbers = new long[0];

        for (long i = this.start; i < this.end; i++)
        {

            long s1 = SumOfDivisors(i);
            long s2 = SumOfDivisors(s1);

            if (s2 == i && i < s1)
            {
                //Console.WriteLine("adding {0}", i);
                this.AddNumber(i);
            }
        }
    }

    public override String ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendFormat ("{0},{1}: {{", this.Start, this.End);

        for (int i = 0; i < this.numbers.Length; i++)
        {
            sb.AppendFormat("[{0},{1}]", this.numbers[i],
                this.SumOfDivisors(this.numbers[i]));

            if (i < this.numbers.Length - 1)
                sb.Append(",");
        }

        sb.Append("}");
        return sb.ToString();
    }
}


