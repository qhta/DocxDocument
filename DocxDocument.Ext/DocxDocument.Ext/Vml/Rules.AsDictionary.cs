namespace DocumentModel.Vml;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

public partial class Rules : IDictionary<string, Rule>
{
  public void Add(string key, Rule value)
  {
    var _element = _Element?.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == key);
    if (_element != null)
      throw new InvalidOperationException($"Rule {key} already exists found");
    _ExistingElement.AppendChild(value._Element);
  }

  public bool ContainsKey(string key)
  {
    return _Element?.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == key) != null;
  }

  public bool Remove(string key)
  {
    var _element = _Element?.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == key);
    if (_element == null)
      return false;
    _element.Remove();
    return true;
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out Rule value)
  {
    var _element = _Element?.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == key);
    if (_element != null)
    {
      value = new Rule(_element);
      return true;
    }
    value = null;
    return false;
  }

  public Rule this[string key]
  {
    get
    {
      var _element = _Element?.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == key);
      if (_element != null)
        return new Rule(_element);
      throw new InvalidOperationException($"Rule {key} not found");
    }
    set
    {
      var _element = _Element?.Elements<DXVO.Rule>().FirstOrDefault(item => item.Id == key);
      if (_element != null)
      {
        _element.Type = value.Type;
        _element.ShapeReference = value.ShapeReference;
        _element.How = value.How;
      }
      else
      {
        _element = new DXVO.Rule { Id = key, Type = value.Type, ShapeReference = value.ShapeReference, How = value.How };
        _ExistingElement.AppendChild(_element);
      }
    }
  }

  public ICollection<string> Keys => (ICollection<string>)_ExistingElement.Elements<DXVO.Rule>().Select(item => item.Id).ToList();
  public ICollection<Rule> Values => (ICollection<Rule>)_ExistingElement.Elements<DXVO.Rule>().Select(item => new Rule(item)).ToList();

  public void Add(KeyValuePair<string, Rule> item)
  {
    Add(item.Key, item.Value);
  }

  public bool Contains(KeyValuePair<string, Rule> item)
  {
    return TryGetValue(item.Key, out var value) && value == item.Value;
  }

  public void CopyTo(KeyValuePair<string, Rule>[] array, int arrayIndex)
  {
    _Element?.Elements<DXVO.Rule>().Where(item=>item.Id!=null)
      .Select(item=> new KeyValuePair<string, Rule>(item.Id!, new Rule(item))).ToArray().CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<string, Rule> item)
  {
    if (TryGetValue(item.Key, out var value) && value == item.Value)
      return Remove(item.Key);
    return false;
  }

  IEnumerator<KeyValuePair<string, Rule>> IEnumerable<KeyValuePair<string, Rule>>.GetEnumerator()
  {
    if (_Element != null)
    foreach (var item in _Element.Elements<DXVO.Rule>())
      yield return new KeyValuePair<string, Rule>(item.Id!, new Rule(item));
  }
}
