using System.ServiceModel;

/*
    Vivien Frances Pabuna
    CSE 445 - Dr. Yinong Chen
    Fall 2022, 09/04/2022
    Assignment 1, Parts 1-2
*/

namespace Assignment1
{
    [ServiceContract]
    public interface IService1
    {

        /*
            Interface for celsius to fahrenheit temp converter method.
        */
        [OperationContract]
        int c2f(int originalTemp);

        /*
            Interface for fahrenheit to celsius temp converter method.
        */
        [OperationContract]
        int f2c(int originalTemp);

        /*
            Interface for number string sorter method.
        */
        [OperationContract]
        string sort(string s);

    }
}
