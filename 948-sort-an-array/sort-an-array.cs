public class Solution {
    public int[] SortArray(int[] nums) {
        QuickSort(nums, 0, nums.Length - 1);
        
        return nums;
    }

    public int[] QuickSort(int[] nums, int start, int end){
        if(start >= end)
            return nums;

        int pivotIndex = MedianOfThree(nums, start, end);
        Swap(nums, pivotIndex, end);

        var pivot = nums[end];
        var leftPointer = start;

        for(int i = start; i <= end; i++){
            if(nums[i] < pivot){
                var temp = nums[leftPointer];
                nums[leftPointer] = nums[i];
                nums[i] = temp;
                leftPointer++;
            }
        }

        nums[end] = nums[leftPointer];
        nums[leftPointer] = pivot;

        QuickSort(nums, start, leftPointer - 1);
        QuickSort(nums, leftPointer + 1, end);

        return nums; 
    }

    private void Swap(int[] nums, int i, int j) {
        int temp = nums[i];
        nums[i] = nums[j];
        nums[j] = temp;
    }

    private int MedianOfThree(int[] nums, int start, int end) {
        int mid = start + (end - start) / 2;

        // Valores do primeiro, do meio e do último elementos
        int a = nums[start];
        int b = nums[mid];
        int c = nums[end];

        // Determina a mediana entre a, b e c
        if ((a > b) != (a > c))
            return start; // 'a' é a mediana
        else if ((b > a) != (b > c))
            return mid; // 'b' é a mediana
        else
            return end; // 'c' é a mediana
    }
}