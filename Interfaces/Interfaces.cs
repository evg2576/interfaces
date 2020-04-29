using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Interfaces
{
    //TODO: Use code from previous task ("Aggregation").



    //TODO: Create interface: "IProlongable".

    //TODO: Create method "CanToProlong" signature that returns true or false.



    //TODO: Implement interface "IProlongable" in class "SpecialDeposit".

    //Interface's method should return true if deposited more than 1000 UAH.



    //TODO: Implement interface "IProlongable" in class "LongDeposit".

    //Interface's method should return true if deposit term was no more than 3 years.



    //TODO: Implement interface "IComparable<Deposit>" in abstract class "Deposit".

    //Use general sum of money (deposit amount plus interest on the deposit for the entire period) as a comparison criterion.



    //TODO: Implement interface "IEnumerable<Deposit>" in class "Client".

    //TODO: Create public method "SortDeposits" that sorts array of deposits by general sum of money in descending order.

    //TODO: Create public method "CountPossibleToProlongDeposit" that returns amount of current client's deposits that can be prolonged.

}