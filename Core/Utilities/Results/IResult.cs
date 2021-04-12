using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için başlangıç
    public interface IResult //Sonuç
    {
        bool Success { get; }//Sadece Okunabilir...Başarılımı? başarısız mı?
        string Message { get; }// Bilgilendirme...

    }
}
