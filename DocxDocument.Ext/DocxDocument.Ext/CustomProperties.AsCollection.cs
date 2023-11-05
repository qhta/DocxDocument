namespace DocumentModel;

[CollectionDataContract]
public partial class CustomProperties : ICollection<CustomProperty>
{
  public void Add(CustomProperty value)
  {
    _CustomFileProperties.AppendChild(value._ExistingElement);
  }

  public void Clear()
  {
    _CustomFileProperties.RemoveAllChildren<DXCP.CustomDocumentProperty>();
  }

  public bool Contains(CustomProperty value)
  {
    return _CustomFileProperties.Elements<DXCP.CustomDocumentProperty>().FirstOrDefault(item => item.PropertyId?.Value == value.Id)!=null;
  }

  public void CopyTo(CustomProperty[] array, int arrayIndex)
  {
    _CustomFileProperties.Elements<DXCP.CustomDocumentProperty>()
      .Select(item => new CustomProperty(item)).ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(CustomProperty value)
  {
    var _element = _CustomFileProperties.Elements<DXCP.CustomDocumentProperty>().FirstOrDefault(item => item.PropertyId?.Value == value.Id);
    if (_element != null ) 
    {
      _element.Remove();
      return true;
    }
    return false;
  }

  public int Count => _CustomFileProperties.Count();

  public bool IsReadOnly => false;

  public IEnumerator<CustomProperty> GetEnumerator()
  {
    foreach (var item in _CustomFileProperties)
      yield return new CustomProperty(item);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
