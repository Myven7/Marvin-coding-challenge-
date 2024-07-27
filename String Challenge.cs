using System;

class Program
{
    static void Main()
    {
        string s = "The quick brown fox jumps over the lazy dog";

        string[] subs = s.Split(' ');

        foreach (var sub in subs)
        {
            char[] value = sub.ToCharArray();
            Array.Reverse(value);
            string result = new string(value);
            Console.WriteLine(result);
        }
    }
}

import java.util.HashSet;

public class Solution {
    public int uniqueAbsCount(int[] A) {
        HashSet<Integer> abNumbers = new HashSet<>();

        for (int i = 0; i < A.length; i++) {
            abNumbers.add(Math.abs(A[i]));
        }

        return abNumbers.size();
    }
}


public class Solution {
    public int solution(int X, int Y, int D) {
        int jumpProgress = X;
        int count = 0;

        while (jumpProgress < Y) {
            jumpProgress += D;
            count++;
        }

        return count;
    }
}

public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
}

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        while (list1 != null && list2 != null) {
            if (list1.val <= list2.val) {
                tail.next = list1;
                list1 = list1.next;
            } else {
                tail.next = list2;
                list2 = list2.next;
            }
            tail = tail.next;
        }

        if (list1 != null) {
            tail.next = list1;
        } else if (list2 != null) {
            tail.next = list2;
        }

        return dummy.next;
    }
}

public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];

        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }

        return result;
    }

    static void Main()
    {
        Solution sol = new Solution();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = sol.TwoSum(nums, target);
        Console.WriteLine("[" + result[0] + ", " + result[1] + "]");
    }
}
