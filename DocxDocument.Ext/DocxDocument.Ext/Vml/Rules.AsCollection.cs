namespace DocumentModel.Vml;

public partial class Rules: ICollection<Rule>
{
  public void Add(Rule value)
  {
    if (value.Id == null)
      throw new InvalidOperationException($"Item.Id must not be null");
    var _element = _Element.Elements<DXVO.Rule>().FirstOrDefault(item=>item.Id == value.Id);
    if (_element != null)
      throw new InvalidOperationException($"Caption \"{value.Id}\" aready exists");
    _Element.AppendChild(value._Element);
  }

  public void Clear()
  {
    _Element.RemoveAllChildren<DXVO.Rule>();
  }

  public bool Contains(Rule value)
  {
    return _Element.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == value.Id) !=null;
  }

  public void CopyTo(Rule[] array, int arrayIndex)
  {
    var temp = _Element.Elements<DXVO.Rule>().ToArray();
    temp.CopyTo(array, arrayIndex);

  }

  public bool Remove(Rule value)
  {
    var _element = _Element.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == value.Id);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public int Count => _Element.Elements<DXVO.Rule>().Count();

  public bool IsReadOnly => false;

  public IEnumerator<Rule> GetEnumerator()
  {
    foreach (var item in _Element.Elements<DXVO.Rule>().ToArray())
      yield return new Rule(item);
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return this.GetEnumerator();
  }
}
