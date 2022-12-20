namespace DocumentModel.Properties;

public partial interface CustomProperties: IEnumerable<CustomDocumentProperty>
{
  public int Count { get; }

  public object? Get(string propName);

}