namespace DocumentModel.Properties;

public partial interface CoreProperties
{
  public int Count();

  public object? Get(string propName);
}