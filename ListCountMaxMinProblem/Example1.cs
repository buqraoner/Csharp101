// case 2
// 
// //7 69 2 221 8974
// Your Output (stdout)
// 299 9271
// Expected Output
// 
// Download
// 
// case 1
// 1 2 3 4 5
// Your Output (stdout)
// 10 14
// Expected Output
// 
// Download
// 10 14

using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        int minimum = 0;
        int maximum = 0;
        int degiskentutucu = 0;
        int degiskentutucu2 = 1;
       
        
        for(int i = 0; i<arr.Count; i++){
            
            if(i < arr.Count -1)
            {
                minimum +=  arr[i];
                
                
            }
            }
            // 1 ,2 ,3 ,4 ,5
            foreach(var sayilar in arr){
                
                 degiskentutucu += sayilar;
                 
                 if(degiskentutucu2 < degiskentutucu){
                     degiskentutucu2 -= degiskentutucu2;
                     degiskentutucu -=sayilar; 
                     degiskentutucu2 =sayilar;
                     
                     maximum +=sayilar;
                     
                     
                     
                     
                 }    
            
                    
                     
                     
                 
                 
                
            }
           
            
            
       
        
        Console.Write(minimum + " " + maximum);

    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}



///////////// false



