namespace DocumentModel.Properties;

public partial interface CoreProperties
{
  public int Count { get; }

  public object? Get(string propName);
}