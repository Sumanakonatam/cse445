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
            Interface for converting a number to its corresponding words.
        */
        [OperationContract]
        string number2Words(int num);

    }
}
