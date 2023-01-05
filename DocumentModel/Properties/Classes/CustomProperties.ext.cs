namespace DocumentModel.Properties;

public partial class CustomProperties : ICollection<CustomDocumentProperty>
{
  public int Count()
  {
    return CustomDocumentProperties?.Count ?? 0;
  }

  public object? Get(string propName)
  {
    var prop = CustomDocumentProperties?.FirstOrDefault(item => item.Name == propName);
    return prop?.Value;
  }

  public IEnumerator<CustomDocumentProperty> GetEnumerator()
  {
    if (this.CustomDocumentProperties == null)
      yield break;
    foreach (var item in this.CustomDocumentProperties)
      yield return item;
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(object obj)
  {
    if (obj is DocumentModel.Properties.CustomDocumentProperty item)
      Add(item);
  }

  public void Add(CustomDocumentProperty item)
  {
    if (CustomDocumentProperties == null)
      CustomDocumentProperties = new Collection<CustomDocumentProperty>();
    CustomDocumentProperties.Add(item);
  }

  public void Clear()
  {
    CustomDocumentProperties?.Clear();
  }

  public bool Contains(CustomDocumentProperty item)
  {
    return CustomDocumentProperties?.Contains(item) ?? false;
  }

  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    if (CustomDocumentProperties != null)
      foreach (var item in CustomDocumentProperties)
        array.SetValue(item, arrayIndex++);
  }

  public void CopyTo(CustomDocumentProperty[] array, int arrayIndex)
  {
    CustomDocumentProperties?.CopyTo(array, arrayIndex);
  }

  public bool Remove(CustomDocumentProperty item)
  {
    return CustomDocumentProperties?.Remove(item) ?? false;
  }

  int ICollection<CustomDocumentProperty>.Count => Count();

  bool ICollection<CustomDocumentProperty>.IsReadOnly => false;
}