// using params modifier
namespace MyCalc{
    public class Calculator{
        public int Addition(params int[] numbers){
            int sum = 0;
            foreach (var num in numbers )
            {
                //sum = sum + num;
                sum += num;
            }
            return sum;

        }
    }
}