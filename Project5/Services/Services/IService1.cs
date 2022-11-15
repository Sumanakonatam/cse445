using System.ServiceModel;

/*
    Vivien Frances Pabuna
    CSE 445 - Dr. Yinong Chen
    Fall 2022, 10/16/2022
    Assignment 5
*/

namespace Services
{
    [ServiceContract]
    public interface IService1
    {

        /*
            Interface for the method to get content at the given URL.
        */
        [OperationContract]
        string getContent(string url);

        /*
            Interface for converting a number to its corresponding words.
        */
        [OperationContract]
        string number2Words(int num);

    }
}
