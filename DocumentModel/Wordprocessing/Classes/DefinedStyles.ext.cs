using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public partial class DefinedStyles : ObservableCollection<Style>//, IDictionary<string, Style>
{
  private readonly SortedDictionary<string, Style> _StyleIds = null!;

  public DefinedStyles()
  {
    _StyleIds = new SortedDictionary<string, Style>();
    CollectionChanged += Styles_CollectionChanged;
  }

  [XmlIgnore]
  public IDictionary<string, Style> StyleIndex => _StyleIds;

  //public IEnumerable<Style> DefinedStyles => this.Where(item => item.IsDefined);
  public IEnumerable<Style> ParagraphStyles => this.Where(item => item.Type==StyleKind.Paragraph);
  public IEnumerable<Style> CharacterStyles => this.Where(item => item.Type==StyleKind.Character);
  public IEnumerable<Style> TableStyles => this.Where(item => item.Type==StyleKind.Table);
  public IEnumerable<Style> NumberingStyles => this.Where(item => item.Type==StyleKind.Numbering);

  public void Add(string key, Style value)
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

  //IEnumerator<KeyValuePair<string, Style>> IEnumerable<KeyValuePair<string, Style>>.GetEnumerator()
  //{
  //  return ((IEnumerable<KeyValuePair<string, Style>>)StyleIndex).GetEnumerator();
  //}

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
        foreach (var item in this)
        {
          var style = item;
          style.PropertyChanging -= Item_PropertyChanging;
          style.PropertyChanged -= Item_PropertyChanged;
        }
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

  //bool ICollection<KeyValuePair<string, Style>>.IsReadOnly { get; }
}