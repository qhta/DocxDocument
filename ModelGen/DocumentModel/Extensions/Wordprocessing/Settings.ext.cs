namespace DocumentModel.Wordprocessing;

public partial interface Settings
{
    public int Count { get; }

    public object? Get(string propName);

}