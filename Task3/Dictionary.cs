namespace Task3
{
    class Dictionary<Tkey, TValue>
    {
        DictionaryList<Tkey, TValue> dictionaryList;

        //Dictionary - конструктор по умолчанию, передающий размерность массива arraySize экземлпяру класса dictionaryList
        public Dictionary(int arraySize)
        {
            dictionaryList = new DictionaryList<Tkey, TValue>(arraySize);
        }

        //Индексатор типа string для получения значеня пар слов по указанному индексу типа string
        public string this[string index] => dictionaryList[index];

        //TotalNumberOfElementPairs - свойство, выдающее общее количество пар элементов слов
        public int TotalNumberOfElementPairs => dictionaryList.TotalPairsOfElements;

        //AddParisOfElements - метод, передающий пары слов в метод AddPairsOfWords класса dictionaryList
        public void AddPairsOfElements(Tkey keyEngWord, TValue keyRusValue)
        {
            dictionaryList.AddPairsOfWords(keyEngWord, keyRusValue);
        }
    }
}
