using ISystem.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines IStyles.
/// </summary>
public partial class DefinedStyles : ElementCollection<IStyle>
{
  private readonly SortedDictionary<string, IStyle> _StyleIds = null!;

  public DefinedStyles()
  {
    _StyleIds = new SortedDictionary<string, IStyle>();
    CollectionChanged += Styles_CollectionChanged;
  }

  [XmlIgnore]
  public IDictionary<string, IStyle> StyleIndex => _StyleIds;

  public IEnumerable<IStyle> ParagraphStyles => this.Where(item => item.Type==StyleKind.IParagraph);
  public IEnumerable<IStyle> CharacterStyles => this.Where(item => item.Type==StyleKind.Character);
  public IEnumerable<IStyle> TableStyles => this.Where(item => item.Type==StyleKind.ITable);
  public IEnumerable<IStyle> NumberingStyles => this.Where(item => item.Type==StyleKind.Numbering);

  public void Add(string key, IStyle value)
  {
    this.Add(value);
    StyleIndex.TryAdd(key, value);
  }

  public bool ContainsKey(string key)
  {
    return StyleIndex.ContainsKey(key);
  }

  public bool Remove(string key)
  {
    if (StyleIndex.TryGetValue(key, out var value))
      this.Remove(value);
    return StyleIndex.Remove(key);
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out IStyle value)
  {
    return StyleIndex.TryGetValue(key, out value);
  }

  public IStyle this[string key]
  {
    get => StyleIndex[key];
    set => StyleIndex[key] = value;
  }

  [XmlIgnore]
  public ICollection<string> Keys => StyleIndex.Keys;
  
  [XmlIgnore]

  public ICollection<IStyle> Values => StyleIndex.Values;

  public void Add(KeyValuePair<string, IStyle> item)
  {
    ((ICollection<KeyValuePair<string, IStyle>>)StyleIndex).Add(item);
  }

  public bool Contains(KeyValuePair<string, IStyle> item)
  {
    return ((ICollection<KeyValuePair<string, IStyle>>)StyleIndex).Contains(item);
  }

  public void CopyTo(KeyValuePair<string, IStyle>[] array, int arrayIndex)
  {
    ((ICollection<KeyValuePair<string, IStyle>>)StyleIndex).CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<string, IStyle> item)
  {
    return ((ICollection<KeyValuePair<string, IStyle>>)StyleIndex).Remove(item);
  }

  //IEnumerator<KeyValuePair<string, IStyle>> IEnumerable<KeyValuePair<string, IStyle>>.GetEnumerator()
  //{
  //  return ((IEnumerable<KeyValuePair<string, IStyle>>)StyleIndex).GetEnumerator();
  //}

  private void _StyleIdsAdd(string id, IStyle value)
  {
    if (_StyleIds.ContainsKey(id))
      _StyleIds[id] = value;
    else
      _StyleIds.Add(id, value);
  }

  private void Styles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    switch (args.Action)
    {
      case NotifyCollectionChangedAction.Reset:
        foreach (var item Iin this)
        {
          var style = item;
          style.PropertyChanging -= Item_PropertyChanging;
          style.PropertyChanged -= Item_PropertyChanged;
        }
        break;
      case NotifyCollectionChangedAction.Add:
        if (args.NewItems != null)
          foreach (var newStyle Iin args.NewItems.Cast<IStyle>())
          {
            var id = newStyle.StyleId;
            if (id != null)
              _StyleIdsAdd(id, newStyle);
            newStyle.PropertyChanging += Item_PropertyChanging;
            newStyle.PropertyChanged += Item_PropertyChanged;
          }
        break;
      case NotifyCollectionChangedAction.Replace:
        if (args.OldItems != null)
          foreach (var oldStyle Iin args.OldItems.Cast<IStyle>())
          {
            var id = oldStyle.StyleId;
            if (id != null)
              _StyleIds.Remove(id);
            oldStyle.PropertyChanging -= Item_PropertyChanging;
            oldStyle.PropertyChanged -= Item_PropertyChanged;
          }
        if (args.NewItems != null)
          foreach (var newStyle Iin args.NewItems.Cast<IStyle>())
          {
            var id = newStyle.StyleId;
            if (id != null)
              _StyleIdsAdd(id, newStyle);
            newStyle.PropertyChanging += Item_PropertyChanging;
            newStyle.PropertyChanged += Item_PropertyChanged;
          }
        break;
      case NotifyCollectionChangedAction.Remove:
        if (args.OldItems != null)
          foreach (var oldStyle Iin args.OldItems.Cast<IStyle>())
          {
            var id = oldStyle.StyleId;
            if (id != null)
              _StyleIds.Remove(id);
            oldStyle.PropertyChanging -= Item_PropertyChanging;
            oldStyle.PropertyChanged -= Item_PropertyChanged;
          }
        break;
    }
  }

  private void Item_PropertyChanging(object? sender, PropertyChangingEventArgs args)
  {
    //if (sender is IStyle aStyle)
    //  if (args.PropertyName == nameof(IStyle.StyleId))
    //  {
    //    var styleName = aStyle.Name;
    //    if (styleName != null)
    //      _StyleList.Remove(styleName);
    //  }
  }

  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    //if (sender is IStyle aStyle)
    //  if (args.PropertyName == nameof(IStyle.Name))
    //  {
    //    var styleName = aStyle.Name;
    //    if (styleName != null)
    //      _StyleList.Add(styleName, aStyle);
    //  }
  }

  //bool ICollection<KeyValuePair<string, IStyle>>.IsReadOnly { get; }
}
