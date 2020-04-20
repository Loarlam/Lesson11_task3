namespace Task3
{
    class DictionaryList<T, U> : IDictionary<T, U>
    {
        string[] _arrayOfKeysAndValues;
        int _pairCounter;

        public DictionaryList(int arrayLength)
        {
            _arrayOfKeysAndValues = new string[arrayLength];
        }

        //Индексатор типа string для получения значеня пар слов по указанному индексу типа string
        //В цикле for ищется включение слова в элементах массива
        public string this[string index]
        {
            get
            {
                for (int i = 0; i < _arrayOfKeysAndValues.Length; i++)
                {
                    if (_arrayOfKeysAndValues[i].Contains(index))
                    {
                        return _arrayOfKeysAndValues[i];
                    }
                }
                return $"{index} - нет перевода для этого слова.";
            }
        }

        //TotalPairsOfElements - свойство, выдающее общее количество пар элементов слов
        public int TotalPairsOfElements => _pairCounter;

        //AddParisOfWords - метод добавляет пары слов в массив __arrayOfKeysAndValues
        public void AddPairsOfWords(T key, U value)
        {
            _arrayOfKeysAndValues[_pairCounter] = key + " - " + value;
            _pairCounter++;
        }
    }
}
