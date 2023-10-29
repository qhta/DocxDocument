namespace DocumentModel;

public partial class AutoCaptions: ICollection<AutoCaption>
{
  public void Add(AutoCaption value)
  {
    if (value.Name == null)
      throw new InvalidOperationException($"Item.Name must not be null");
    var _autoCaption = _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item=>item.Name == value.Name);
    if (_autoCaption != null)
      throw new InvalidOperationException($"Caption {value.Name} aready exists found");
    _AutoCaptions.AddChild(value._AutoCaption);
  }

  public void Clear()
  {
    _AutoCaptions.RemoveAllChildren();
  }

  public bool Contains(AutoCaption value)
  {
    return _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == value.Name)!=null;
  }

  public void CopyTo(AutoCaption[] array, int arrayIndex)
  {
    throw new NotImplementedException();
  }

  public bool Remove(AutoCaption value)
  {
    var _autoCaption = _AutoCaptions.Elements<DXW.AutoCaption>().FirstOrDefault(item => item.Name == value.Name);
    if (_autoCaption == null)
      return false;
    _autoCaption.Remove();
    return true;
  }

  public int Count => _AutoCaptions.Elements<DXW.AutoCaption>().Count();

  public bool IsReadOnly => false;

  public IEnumerator<AutoCaption> GetEnumerator()
  {
    foreach (var item in _AutoCaptions.Elements<DXW.AutoCaption>().ToArray())
    {
      yield return new AutoCaption(item);
    }
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
