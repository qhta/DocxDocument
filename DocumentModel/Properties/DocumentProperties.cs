namespace DocumentModel.Properties;

public partial class DocumentProperties : ICollection<DocumentProperty>
{
  [XmlIgnore]
  public CoreProperties? CoreProperties { get; set; }

  [XmlIgnore]
  public ExtendedProperties? ExtendedProperties { get; set; }

  [XmlIgnore]
  public CustomProperties? CustomProperties { get; set; }

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

  public void Add(DocumentProperty item)
  {
    if (CoreProperties == null)
      CoreProperties = new CoreProperties();
    if (ExtendedProperties == null)
      ExtendedProperties = new ExtendedProperties();
    if (item.Name != null)
    {
      if (CoreProperties.GetKnownProperties().ContainsKey(item.Name))
      {
        CoreProperties.Set(item.Name, item.Value);
      }
      else if (ExtendedProperties.GetKnownProperties().ContainsKey(item.Name))
      {
        ExtendedProperties.Set(item.Name, item.Value);
      }
      else
      {
        if (CustomProperties == null)
          CustomProperties = new CustomProperties();
        if (item.Type == null && item.Value is Variant variant)
        {
          item.Type = variant.VariantType;
        }
        CustomProperties.Add(item);
      }
    }
  }

  public void Clear()
  {
    if (CoreProperties != null)
      CoreProperties.Clear();
    if (ExtendedProperties != null)
      ExtendedProperties.Clear();
    if (CustomProperties != null)
      CustomProperties.Clear();
  }

  public bool Contains(DocumentProperty item)
  {
    if (CoreProperties != null && CoreProperties.Contains(item))
      return true;
    if (ExtendedProperties != null && ExtendedProperties.Contains(item))
      return true;
    if (CustomProperties != null && CustomProperties.Contains(item))
      return true;
    return false;
  }

  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    if (CoreProperties != null)
    {
      CoreProperties.CopyTo(array, arrayIndex);
      arrayIndex += CoreProperties.Count();
    }
    if (ExtendedProperties != null)
    {
      ExtendedProperties.CopyTo(array, arrayIndex);
      arrayIndex += ExtendedProperties.Count();
    }
    if (CustomProperties != null)
      CustomProperties.CopyTo(array, arrayIndex);
  }

  public bool Remove(DocumentProperty item)
  {
    if (CoreProperties != null)
      if (CoreProperties.Remove(item))
        return true;
    if (ExtendedProperties != null)
      if (ExtendedProperties.Remove(item))
        return true;
    if (CustomProperties != null)
      if (CustomProperties.Remove(item))
        return true;
    return false;
  }

  int ICollection<DocumentProperty>.Count => Count();

  bool ICollection<DocumentProperty>.IsReadOnly => false;

  public int Count()
  {
    var count = 0;
    if (CoreProperties != null)
      count += CoreProperties.Count();
    if (ExtendedProperties != null)
      count += ExtendedProperties.Count();
    if (CustomProperties != null)
      count += CustomProperties.Count();
    return count;
  }

  public DocumentProperty? GetProperty(string propName)
  {
    DocumentProperty? result;
    if (CoreProperties != null && CoreProperties.GetKnownProperties().ContainsKey(propName))
      result = CoreProperties.GetProperty(propName);
    else
    if (ExtendedProperties != null && ExtendedProperties.GetKnownProperties().ContainsKey(propName))
      result = ExtendedProperties.GetProperty(propName);
    else
      result = CustomProperties?.GetProperty(propName);
    return result;
  }

  public object? GetValue(string propName)
  {
    object? result;
    if (CoreProperties!=null && CoreProperties.GetKnownProperties().ContainsKey(propName))
      result = CoreProperties.GetValue(propName);
    else
    if (ExtendedProperties != null && ExtendedProperties.GetKnownProperties().ContainsKey(propName))
      result = ExtendedProperties.GetValue(propName);
    else
      result = CustomProperties?.GetValue(propName);
    return result;
  }

  public void Add(object item)
  {
    if (item is DocumentProperty documentProperty)
      Add(documentProperty);
  }
}