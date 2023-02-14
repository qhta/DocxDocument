using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public partial class DefinedStyles : ICollection, ICollection<Style>, IDictionary<string, Style>
{
  private readonly ObservableCollection<Style> _AllStyles = null!;
  private readonly SortedDictionary<string, Style> _StyleIds = null!;

  public DefinedStyles()
  {
    _StyleIds = new SortedDictionary<string, Style>();
    _AllStyles = new();
    _AllStyles.CollectionChanged += Styles_CollectionChanged;
  }

  /// <summary>
  /// Defines Styles.
  /// </summary>
  [XmlIgnore]
  public Collection<Style> Items
  {
    get => _AllStyles;
    set
    {
      foreach (var item in value)
      {
        _AllStyles.Add(item);
      }
    }
  }

  [XmlIgnore]
  public ICollection<Style> AllStyles
  {
    get => _AllStyles;
    set
    {
      foreach (var item in value)
      {
        _AllStyles.Add(item);
      }
    }
  }

  [XmlIgnore]
  public IDictionary<string, Style> StyleIndex => _StyleIds;

  //public IEnumerable<Style> DefinedStyles => AllStyles.Where(item => item.IsDefined);
  public IEnumerable<Style> ParagraphStyles => AllStyles.Where(item => item.Type==StyleKind.Paragraph);
  public IEnumerable<Style> CharacterStyles => AllStyles.Where(item => item.Type==StyleKind.Character);
  public IEnumerable<Style> TableStyles => AllStyles.Where(item => item.Type==StyleKind.Table);
  public IEnumerable<Style> NumberingStyles => AllStyles.Where(item => item.Type==StyleKind.Numbering);

  public void Add(Style item)
  {
    ((ICollection<Style>)AllStyles).Add(item);
  }

  public void Clear()
  {
    ((ICollection<Style>)AllStyles).Clear();
  }

  public bool Contains(Style item)
  {
    return ((ICollection<Style>)AllStyles).Contains(item);
  }

  public void CopyTo(Style[] array, int arrayIndex)
  {
    ((ICollection<Style>)AllStyles).CopyTo(array, arrayIndex);
  }

  public bool Remove(Style item)
  {
    return ((ICollection<Style>)AllStyles).Remove(item);
  }

  public int Count => ((ICollection<Style>)AllStyles).Count;

  public bool IsReadOnly => ((ICollection<Style>)AllStyles).IsReadOnly;

  public IEnumerator<Style> GetEnumerator()
  {
    return ((IEnumerable<Style>)AllStyles).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)AllStyles).GetEnumerator();
  }

  public void Add(string key, Style value)
  {
    AllStyles.Add(value);
    StyleIndex.TryAdd(key, value);
  }

  public bool ContainsKey(string key)
  {
    return StyleIndex.ContainsKey(key);
  }

  public bool Remove(string key)
  {
    if (StyleIndex.TryGetValue(key, out var value))
      AllStyles.Remove(value);
    return StyleIndex.Remove(key);
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out Style value)
  {
    return StyleIndex.TryGetValue(key, out value);
  }

  public Style this[string key]
  {
    get => StyleIndex[key];
    set => StyleIndex[key] = value;
  }

  [XmlIgnore]
  public ICollection<string> Keys => StyleIndex.Keys;
  
  [XmlIgnore]

  public ICollection<Style> Values => StyleIndex.Values;

  public void Add(KeyValuePair<string, Style> item)
  {
    ((ICollection<KeyValuePair<string, Style>>)StyleIndex).Add(item);
  }

  public bool Contains(KeyValuePair<string, Style> item)
  {
    return ((ICollection<KeyValuePair<string, Style>>)StyleIndex).Contains(item);
  }

  public void CopyTo(KeyValuePair<string, Style>[] array, int arrayIndex)
  {
    ((ICollection<KeyValuePair<string, Style>>)StyleIndex).CopyTo(array, arrayIndex);
  }

  public bool Remove(KeyValuePair<string, Style> item)
  {
    return ((ICollection<KeyValuePair<string, Style>>)StyleIndex).Remove(item);
  }

  IEnumerator<KeyValuePair<string, Style>> IEnumerable<KeyValuePair<string, Style>>.GetEnumerator()
  {
    return ((IEnumerable<KeyValuePair<string, Style>>)StyleIndex).GetEnumerator();
  }

  private void _StyleIdsAdd(string id, Style value)
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
        foreach (var item in _AllStyles)
        {
          var style = item;
          style.PropertyChanging -= Item_PropertyChanging;
          style.PropertyChanged -= Item_PropertyChanged;
        }
        _AllStyles.Clear();
        break;
      case NotifyCollectionChangedAction.Add:
        if (args.NewItems != null)
          foreach (var newStyle in args.NewItems.Cast<Style>())
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
          foreach (var oldStyle in args.OldItems.Cast<Style>())
          {
            var id = oldStyle.StyleId;
            if (id != null)
              _StyleIds.Remove(id);
            oldStyle.PropertyChanging -= Item_PropertyChanging;
            oldStyle.PropertyChanged -= Item_PropertyChanged;
          }
        if (args.NewItems != null)
          foreach (var newStyle in args.NewItems.Cast<Style>())
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
          foreach (var oldStyle in args.OldItems.Cast<Style>())
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
    //if (sender is Style aStyle)
    //  if (args.PropertyName == nameof(Style.StyleId))
    //  {
    //    var styleName = aStyle.Name;
    //    if (styleName != null)
    //      _StyleList.Remove(styleName);
    //  }
  }

  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    //if (sender is Style aStyle)
    //  if (args.PropertyName == nameof(Style.Name))
    //  {
    //    var styleName = aStyle.Name;
    //    if (styleName != null)
    //      _StyleList.Add(styleName, aStyle);
    //  }
  }

  void ICollection.CopyTo(Array array, int index)
  {
    throw new NotImplementedException();
  }

  bool ICollection.IsSynchronized { get; }
  object ICollection.SyncRoot { get; } = new object();

}