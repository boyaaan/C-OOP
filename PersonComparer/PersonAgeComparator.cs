﻿namespace BoxOfT
{    
    using System.Collections.Generic;
    
    public class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
