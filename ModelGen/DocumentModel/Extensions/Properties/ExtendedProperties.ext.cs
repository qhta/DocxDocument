namespace DocumentModel.Properties;

public partial interface ExtendedProperties
{
  public int Count();

  public object? Get(string propName);

}