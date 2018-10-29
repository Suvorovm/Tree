using System.Diagnostics;

namespace Tree
{
    public class DoubleList
    {
        public override string ToString()
        {
            return Head.Data.ToString();
        }
        private Element Head { get; set; }//      
      // Поиск слова
        public bool SerchWord(string s)
        {
            SerchSymbolsForResult(s.ToCharArray());
        }

        private bool SerchSymbolsForResult(char[] array)
        {
            var temrory = Head;
            for (int i = 0; i < array.Length; i++)
            {

            }
        }
        //преобразование входного слова в массив char
        public void AddWord(string s)
        {
            if (Head == null)
            {
                Head = new Element();//создаем корень
                AddSymbols(s.ToCharArray());             
            }
            else
            {
                AddSymbols(s.ToCharArray());
            }
        }
      //метод добавления, если уже известно, что внизу нет ничего, и не найден символ 
        private void AddCascadElements(int index,Element element,char[] arrayOfSymbols)
        {
            Debug.WriteLine("Метод добавления каскадом");
            var time = element;
            for (int i = index; i < arrayOfSymbols.Length; i++)
            {
                var temrory = new Element
                {
                    Data = arrayOfSymbols[i]
                };
                time.Down = temrory;
                time = temrory;
            }
            var temprory = new Element
            {
                Data = '*',
                Down = null
            };
            time.Down = temprory;
        }
        //добавление слов
        private void AddSymbols(char[] arrayOfSymbols)
        {
            Debug.WriteLine("AddSymbols");
            var temrory = Head;
            for (int i = 0; i < arrayOfSymbols.Length; i++)
            {             
                if (!SerchSymbolRight(temrory, arrayOfSymbols[i]))
                {
                    temrory =  AddSymbolRightEnd(temrory, arrayOfSymbols[i]);
                    AddCascadElements(i+1, temrory, arrayOfSymbols);
                    break;
                }
                {
                    temrory = GetReferencOfElement(temrory, arrayOfSymbols[i]);
                    temrory = temrory.Down;
                }               
            } 
        }
        //добавление в случе, если не найден справа
        private Element AddSymbolRightEnd(Element element,char symbol)
        {
            Debug.WriteLine("AddSymbolRightEnd");
            Element temrory = new Element();
            while(element.Right != null)
            {
                element = element.Right;
            }
            element.Right = temrory;
            temrory.Data = symbol;
            temrory.Right = null;
            temrory.Down = null;
            return temrory;
        }
        //поиск эллемента справа
         private bool SerchSymbolRight(Element Upster,char symbol)
        {
            Debug.WriteLine("SerchSymbolRight");
            while (Upster != null)
            {
                if(Upster.Data == symbol)
                {
                    return true;
                }
                else
                {
                    Upster = Upster.Right; 
                }
            }
            return false;
        }
      
        // возвращение эллемента справва, который уже был найден
        //для перехода вниз
         private Element GetReferencOfElement(Element Upster, char symbol)
        {
            Debug.WriteLine("GetReferencOfElement");
            var temprory = Upster;
            while (temprory.Data != symbol)//возможно  символ на null
            {
                temprory = temprory.Right;
            }
            return temprory;
        }
    }
}
