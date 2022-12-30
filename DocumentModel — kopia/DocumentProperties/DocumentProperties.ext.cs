namespace DocumentModel.Properties;


public partial class DocumentProperties: IEnumerable<DocumentProperty>
{
  public int Count()
  {
    int count = 0;
    if (CoreProperties != null)
      count += CoreProperties.Count();
    if (ExtendedProperties != null)
      count += ExtendedProperties.Count();
    if (CustomProperties != null)
      count += CustomProperties.Count();

    return count;
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

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    if (CoreProperties != null)
      foreach (var property in CoreProperties)
        yield return property;
    if (ExtendedProperties != null)
      foreach (var property in ExtendedProperties)
        yield return property;
    if (CustomProperties != null)
      foreach (var property in CustomProperties)
        yield return property;
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(object item)
  {
    if (item is DocumentProperty documentProperty)
    {
      if (documentProperty.Name!=null)
      {
        if (CoreProperties == null)
          CoreProperties = new CoreProperties();
        if (CoreProperties.GetPropNames().Contains(documentProperty.Name))
          CoreProperties.Set(documentProperty.Name, documentProperty.Value);
        else
        if (ExtendedProperties.GetPropNames().Contains((documentProperty.Name)))
        {
          if (ExtendedProperties == null)
            ExtendedProperties = new ExtendedProperties();
          ExtendedProperties.Set(documentProperty.Name, documentProperty.Value);
        }
        else
        {
          if (CustomProperties == null)
            CustomProperties = new CustomProperties();
          if (documentProperty is CustomDocumentProperty customDocumentProperty)
            CustomProperties.Add(customDocumentProperty);
        }
      }
    }
  }
}