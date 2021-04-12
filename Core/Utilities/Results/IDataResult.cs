using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>: IResult //<T> döndüreceğin tipi bana söyle...
    {
        T Data { get; } //T tipinde bir data olacak...
    }
}
