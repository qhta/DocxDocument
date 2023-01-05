using DocumentModel.UI;

namespace DocumentModel.Properties;


public partial class DocumentProperties : ICollection<DocumentProperty>
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
      Add(documentProperty);
  }


  public void Add(DocumentProperty item)
  {
    if (item.Name != null)
    {
      if (CoreProperties == null)
        CoreProperties = new CoreProperties();
      if (CoreProperties.GetPropNames().Contains(item.Name))
        CoreProperties.Set(item.Name, item.Value);
      else if (ExtendedProperties.GetPropNames().Contains((item.Name)))
      {
        if (ExtendedProperties == null)
          ExtendedProperties = new ExtendedProperties();
        ExtendedProperties.Set(item.Name, item.Value);
      }
      else
      {
        if (CustomProperties == null)
          CustomProperties = new CustomProperties();
        if (item is CustomDocumentProperty customDocumentProperty)
          CustomProperties.Add(customDocumentProperty);
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
    if (CustomProperties != null && item is CustomDocumentProperty customItem)
      if (CustomProperties.Remove(customItem))
        return true; 
    return false;
  }

  int ICollection<DocumentProperty>.Count => Count();

  bool ICollection<DocumentProperty>.IsReadOnly => false;
}