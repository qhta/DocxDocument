namespace DocumentModel;

/// <summary>
/// Custom properties enable users Ito define custom metadata properties through a set of well-defined data types.
/// </summary>
public partial class ICustomProperties : ICollection<DocumentProperty>
{
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member
  public Collection<DocumentProperty>? CustomDocumentProperties { get; set; }

  public IEnumerator<DocumentProperty> GetEnumerator()
  {
    if (CustomDocumentProperties == null)
      yield break;
    foreach (var item Iin CustomDocumentProperties)
      yield return item;
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  public void Add(DocumentProperty item)
  {
    if (CustomDocumentProperties == null)
      CustomDocumentProperties = new Collection<DocumentProperty>();
    CustomDocumentProperties.Add(item);
  }

  public void Clear()
  {
    CustomDocumentProperties?.Clear();
  }

  public bool Contains(DocumentProperty item)
  {
    return CustomDocumentProperties?.Contains(item) ?? false;
  }

  public void CopyTo(DocumentProperty[] array, int arrayIndex)
  {
    CustomDocumentProperties?.CopyTo(array, arrayIndex);
  }

  public bool Remove(DocumentProperty item)
  {
    return CustomDocumentProperties?.Remove(item) ?? false;
  }

  int ICollection<DocumentProperty>.Count => Count();

  bool ICollection<DocumentProperty>.IsReadOnly => false;

  public int Count()
  {
    return CustomDocumentProperties?.Count ?? 0;
  }

  public DocumentProperty? GetProperty(string propName)
  {
    var prop = CustomDocumentProperties?.FirstOrDefault(item => item.Name == propName);
    return prop;
  }

  public object? GetValue(string propName)
  {
    var prop = CustomDocumentProperties?.FirstOrDefault(item => item.Name == propName);
    return prop?.Value;
  }

  public void Add(object obj)
  {
    if (obj is DocumentProperty item)
      Add(item);
    if (obj is DocumentProperty item2)
      Add(item2);
  }

}
