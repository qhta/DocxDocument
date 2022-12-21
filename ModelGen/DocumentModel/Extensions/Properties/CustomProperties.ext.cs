namespace DocumentModel.Properties;

public partial interface CustomProperties: IEnumerable<CustomDocumentProperty>
{
  public int Count();

  public object? Get(string propName);

}