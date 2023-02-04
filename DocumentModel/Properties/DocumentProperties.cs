using DocumentModel.Wordprocessing;

namespace DocumentModel.Properties;

public partial class DocumentProperties : ICollection<DocumentProperty>
{
  [XmlIgnore]
  public CoreProperties? CoreProperties { get; set; }

  [XmlIgnore]
  public ContentProperties? ContentProperties { get; set; }

  [XmlIgnore]
  public StatisticProperties? StatisticProperties { get; set; }

  [XmlIgnore]
  public CustomProperties? CustomProperties { get; set; }

  [XmlIgnore]
  public DocumentSettings? DocumentSettings { get; set; }


  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    if (CoreProperties != null)
      foreach (var property in CoreProperties)
        yield return property;
    if (ContentProperties != null)
      foreach (var property in ContentProperties)
        yield return property;
    if (StatisticProperties != null)
      foreach (var property in StatisticProperties)
        yield return property;
    if (CustomProperties != null)
      foreach (var property in CustomProperties)
        yield return property;
    if (DocumentSettings != null)
      foreach (var property in DocumentSettings)
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
    if (ContentProperties == null)
      ContentProperties = new ContentProperties();
    if (StatisticProperties == null)
      StatisticProperties = new StatisticProperties();
    if (item.Name != null)
    {
      if (CoreProperties.GetKnownProperties().ContainsKey(item.Name))
      {
        CoreProperties.Set(item.Name, item.Value);
      }
      else if (ContentProperties.GetKnownProperties().ContainsKey(item.Name))
      {
        ContentProperties.Set(item.Name, item.Value);
      }
      else if (StatisticProperties.GetKnownProperties().ContainsKey(item.Name))
      {
        StatisticProperties.Set(item.Name, item.Value);
      }
      else if (DocumentSettings.GetKnownProperties().ContainsKey(item.Name))
      {
        StatisticProperties.Set(item.Name, item.Value);
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
    if (ContentProperties != null)
      ContentProperties.Clear();
    if (CustomProperties != null)
      CustomProperties.Clear();
  }

  public bool Contains(DocumentProperty item)
  {
    if (CoreProperties != null && CoreProperties.Contains(item))
      return true;
    if (ContentProperties != null && ContentProperties.Contains(item))
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
    if (ContentProperties != null)
    {
      ContentProperties.CopyTo(array, arrayIndex);
      arrayIndex += ContentProperties.Count();
    }
    if (CustomProperties != null)
      CustomProperties.CopyTo(array, arrayIndex);
  }

  public bool Remove(DocumentProperty item)
  {
    if (CoreProperties != null)
      if (CoreProperties.Remove(item))
        return true;
    if (ContentProperties != null)
      if (ContentProperties.Remove(item))
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
    if (ContentProperties != null)
      count += ContentProperties.Count();
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
    if (ContentProperties != null && ContentProperties.GetKnownProperties().ContainsKey(propName))
      result = ContentProperties.GetProperty(propName);
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
    if (ContentProperties != null && ContentProperties.GetKnownProperties().ContainsKey(propName))
      result = ContentProperties.GetValue(propName);
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