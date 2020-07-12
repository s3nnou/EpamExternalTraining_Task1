using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace epam_task_1
{
    public class EuclidMethods
    {
        /// <summary>
        /// Calculates gdc(a,b)
        /// if a or b is negative value - throws expetion
        /// as an addition - calculates a time of an execution
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="endtime"></param>
        /// <returns>gdc result</returns>
        public int GetGDC(int valueA, int valueB, out long time)
        {
            Stopwatch clock = new Stopwatch();
            clock.Start();

            if (valueA < 0 || valueB < 0)
            {
                valueA = Math.Abs(valueA);
                valueB = Math.Abs(valueB);
            }

            if (valueA == 0)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return valueB;
            }

            else if (valueB == 0)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return valueA;
            }

            else if (valueA == valueB)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return valueA;
            }

            else if (valueA == 1 || valueB == 1)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return 1;
            }

            while (valueA != 0 && valueB != 0)
            {
                if (valueA > valueB)
                {
                    valueA %= valueB;
                }
                else
                {
                    valueB %= valueA;
                }
            }

            clock.Stop();

            time = clock.ElapsedMilliseconds;

            return valueA > valueB ? valueA : valueB;
        }

        /// <summary>
        /// Calculates gdc(gdc(a,b), c)
        /// simply calls original method n-times
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="valueC"></param>
        /// <param name="endtime"></param>
        /// <returns>gdc result</returns>
        public int GetGDC(int valueA, int valueB, int valueC, out long time)
        {
            long globalTime = 0;

            int tempGDCvalue = GetGDC(valueA, valueB, out time);

            globalTime += time;

            return GetGDC(tempGDCvalue, valueC, out globalTime);
        }

        /// <summary>
        /// gdc(gdc(a,b),gdc(c,d))
        /// simply calls original method n-times
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="valueC"></param>
        /// <param name="valueD"></param>
        /// <param name="endtime"></param>
        /// <returns>gdc result</returns>
        public int GetGDC(int valueA, int valueB, int valueC, int valueD, out long time)
        {
            long globalTime = 0;

            int tempGDCvalueA = GetGDC(valueA, valueB, out time);

            globalTime += time;

            int tempGDCvalueB = GetGDC(valueC, valueD, out time);

            globalTime += time;

            return GetGDC(tempGDCvalueA, tempGDCvalueB, out globalTime);

        }

        /// <summary>
        /// gdc(gdc(gdc(a,b),gdc(c,d)), e)
        /// simply calls original method n-times
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="valueC"></param>
        /// <param name="valueD"></param>
        /// <param name="valueE"></param>
        /// <param name="endtime"></param>
        /// <returns>gdc result</returns>
        public int GetGDC(int valueA, int valueB, int valueC, int valueD, int valueE, out long time)
        {
            long globalTime = 0;

            int tempGDCvalueA = GetGDC(valueA, valueB, out time);

            globalTime += time;

            int tempGDCvalueB = GetGDC(valueC, valueD, out time);

            globalTime += time;

            int tempGDCvalueC = GetGDC(tempGDCvalueA, tempGDCvalueB, out time);

            globalTime += time;

            return GetGDC(tempGDCvalueC, valueE, out globalTime);

        }
        /// <summary>
        /// Calculates gdc(a,b) but by using Steins method
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <param name="endtime"></param>
        /// <returns>gdc result</returns>
        public int GetStein(int valueA, int valueB, out long time)
        {
            bool CheckForEven(int value)
            {
                return (value % 2) == 0 ? true : false;
            }

            Stopwatch clock = new Stopwatch();
            clock.Start();

            if (valueA < 0 || valueB < 0)
            {
                valueA = Math.Abs(valueA);
                valueB = Math.Abs(valueB);
            }

            if (valueA == 0)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return valueB;
            }

            else if (valueB == 0)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return valueA;
            }

            else if (valueA == valueB)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return valueA;
            }

            else if (valueA == 1 || valueB == 1)
            {
                clock.Stop();
                time = clock.ElapsedMilliseconds;

                return 1;
            }

            int count = 1;
            while (valueA != 0 && valueB != 0)
            {
                while (CheckForEven(valueA) && CheckForEven(valueB))
                {
                    valueA /= 2;
                    valueB /= 2;

                    count *= 2;
                }
                while (CheckForEven(valueA))
                {
                    valueA /= 2;
                }
                while (CheckForEven(valueB))
                {
                    valueB /= 2;
                }
                if (valueA >= valueB)
                {
                    valueA -= valueB;
                }
                else
                {
                    valueB -= valueA;
                }
            }

            clock.Stop();

            time = clock.ElapsedMilliseconds;

            return valueB * count;
        }

        /// <summary>
        /// collects execution time of the all methods below and creates dictionary for a histogramm usage
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <returns>dictionary with results</returns>
        public Dictionary<string, long> GetTimeCalculatuions(int valueA, int valueB, int valueC, int valueD, int valueE)
        {
            Dictionary<string, long> dataToPass = new Dictionary<string, long>();

            long timeConsumed;

            GetGDC(valueA, valueB, out timeConsumed);

            dataToPass.Add("GDC for the 2 values", timeConsumed);

            timeConsumed = 0;
            GetGDC(valueA, valueB, valueC, out timeConsumed);
            dataToPass.Add("GDC for the 3 values", timeConsumed);

            timeConsumed = 0;
            GetGDC(valueA, valueB, valueC, valueD, out timeConsumed);
            dataToPass.Add("GDC for the 4 values", timeConsumed);

            timeConsumed = 0;
            GetGDC(valueA, valueB, valueC, valueD, valueE, out timeConsumed);
            dataToPass.Add("GDC for the 5 values", timeConsumed);

            timeConsumed = 0;
            GetStein(valueA, valueB, out timeConsumed);
            dataToPass.Add("Stein for the 2 values", timeConsumed);

            return dataToPass;
        }
    }
}
