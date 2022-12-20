namespace DocumentModel.Properties;

public partial interface ExtendedProperties
{
  public int Count { get; }

  public object? Get(string propName);

}