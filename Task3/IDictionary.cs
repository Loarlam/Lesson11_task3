namespace Task3
{
    interface IDictionary<T, U>
    {
        string this[string value] { get; }
        int TotalPairsOfElements { get; }
        void AddPairsOfWords(T key, U value);
    }
}
