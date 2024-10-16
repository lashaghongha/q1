using System;
using System.Collections.Generic;

public class DataHandler<T>
{
    private List<T> data = new List<T>();

 
    public void AddData(T element)
    {
        data.Add(element);
    }


    public T RetrieveData(int index)
    {
        if (index >= 0 && index < data.Count)
        {
            return data[index];
        }
        throw new ArgumentOutOfRangeException("Index is out of range.");
    }
}
