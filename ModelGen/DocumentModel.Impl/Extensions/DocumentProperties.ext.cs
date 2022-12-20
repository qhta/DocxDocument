namespace DocumentModel;

public partial class DocumentPropertiesImpl : DocumentProperties
{
  public DocumentModel.Properties.CoreProperties? CoreProperties { get; set; }
  public DocumentModel.Properties.ExtendedProperties? ExtendedProperties { get; set; }
  public DocumentModel.Properties.CustomProperties? CustomProperties { get; set; }

  public int Count
  {
    get
    {
      int count = 0;
      if (CoreProperties != null) 
        count += CoreProperties.Count;
      if (ExtendedProperties != null)
        count += ExtendedProperties.Count;
      if (CustomProperties != null)
        count += CustomProperties.Count;
      return count;
    }
  }

  public object? Get(string propName)
  {
    var result = CoreProperties?.Get(propName);
    if (result != null) return result;
    result = ExtendedProperties?.Get(propName);
    if (result != null) return result;
    result = CustomProperties?.Get(propName);
    return result;
  }

}