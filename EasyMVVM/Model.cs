/*
Класът на модела съдържа колекция от стрингове. Ще използваме спеманатия по-горе 
ObservableCollection клас, с който не е нужно да пишем сами имплементацията на 
интерфейса INotifyCollectionChanged. За целта ни е необходима библиотеката 
System.Collections.ObjectModel . Данните в колекцията ще се достъпват посредством 
публичен метод GetData(), който за момента ще реализираме така, е да пълни колекцията ни с 
някакви dummy данни и да ги връща. При реална реализация той най-често ще изпълнява 
заявки към база данни и ще черпи колекцията от там.
*/

using System;
using System.Collections.ObjectModel;
namespace EasyMVVM
{
    //The model is a class which the ViewModel knows and uses to get data... 
    public class Model
    {
        // Using a private data store is a good idea private 
        ObservableCollection<string> _data = new ObservableCollection<string>();
        public ObservableCollection<string> GetData()
        {
            // these steps represent the same data to be returned each time GetData is called.
            // typically you'd query a database or put other buisness logic here 
            _data.Add("First Entry");
            _data.Add("Second Entry");
            _data.Add("Third Entry");
            return _data;
        }
    }
}