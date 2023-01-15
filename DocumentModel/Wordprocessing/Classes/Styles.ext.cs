using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
public partial class Styles : ICollection<Style>, IDictionary<string, Style>
{
  private readonly Collection<Style> _Items = null!;

  public Styles()
  {
    _Items = new ObservableCollection<Style>();
    ((ObservableCollection<Style>)Items).CollectionChanged += Styles_CollectionChanged;
  }

  public Collection<Style> Items
  {
    get => _Items;
    set
    {
      if (_Items != value)
      {
        _Items.Clear();
        foreach (var item in value)
          _Items.Add(item);
      }
    }
  }

  private Dictionary<string, Style> StyleIndex { get; } = new();

  public void Add(Style item)
  {
    ((ICollection<Style>)Items).Add(item);
  }

  public void Clear()
  {
    ((ICollection<Style>)Items).Clear();
  }

  public bool Contains(Style item)
  {
    return ((ICollection<Style>)Items).Contains(item);
  }

  public void CopyTo(Style[] array, int arrayIndex)
  {
    ((ICollection<Style>)Items).CopyTo(array, arrayIndex);
  }

  public bool Remove(Style item)
  {
    return ((ICollection<Style>)Items).Remove(item);
  }

  public int Count => ((ICollection<Style>)Items).Count;

  public bool IsReadOnly => ((ICollection<Style>)Items).IsReadOnly;

  public IEnumerator<Style> GetEnumerator()
  {
    return ((IEnumerable<Style>)Items).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Items).GetEnumerator();
  }

  public void Add(string key, Style value)
  {
    ((IDictionary<string, Style>)StyleIndex).Add(key, value);
  }

  public bool ContainsKey(string key)
  {
    return ((IDictionary<string, Style>)StyleIndex).ContainsKey(key);
  }

  public bool Remove(string key)
  {
    return ((IDictionary<string, Style>)StyleIndex).Remove(key);
  }

  public bool TryGetValue(string key, [MaybeNullWhen(false)] out Style value)
  {
    return ((IDictionary<string, Style>)StyleIndex).TryGetValue(key, out value);
  }

  public Style this[string key]
  {
    get => ((IDictionary<string, Style>)StyleIndex)[key];
    set => ((IDictionary<string, Style>)StyleIndex)[key] = value;
  }

  public ICollection<string> Keys => ((IDictionary<string, Style>)StyleIndex).Keys;

  public ICollection<Style> Values => ((IDictionary<string, Style>)StyleIndex).Values;

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

  private void Styles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    switch (args.Action)
    {
      case NotifyCollectionChangedAction.Reset:
        foreach (var item in StyleIndex)
        {
          var style = item.Value;
          style.PropertyChanging -= Item_PropertyChanging;
          style.PropertyChanged -= Item_PropertyChanged;
        }
        StyleIndex.Clear();
        break;
      case NotifyCollectionChangedAction.Add:
        if (args.NewItems != null)
          foreach (var newStyle in args.NewItems.Cast<Style>())
          {
            if (newStyle.StyleName != null)
              StyleIndex.Add(newStyle.StyleName, newStyle);
            newStyle.PropertyChanging += Item_PropertyChanging;
            newStyle.PropertyChanged += Item_PropertyChanged;
          }
        break;
      case NotifyCollectionChangedAction.Remove:
        if (args.OldItems != null)
          foreach (var oldStyle in args.OldItems.Cast<Style>())
          {
            oldStyle.PropertyChanging -= Item_PropertyChanging;
            oldStyle.PropertyChanged -= Item_PropertyChanged;
            if (oldStyle.StyleName != null)
              StyleIndex.Remove(oldStyle.StyleName);
          }
        break;
    }
  }

  private void Item_PropertyChanging(object? sender, PropertyChangingEventArgs args)
  {
    if (sender is Style aStyle)
      if (args.PropertyName == nameof(Style.StyleName))
      {
        var styleName = aStyle.StyleName;
        if (styleName != null)
          StyleIndex.Remove(styleName);
      }
  }

  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (sender is Style aStyle)
      if (args.PropertyName == nameof(Style.StyleName))
      {
        var styleName = aStyle.StyleName;
        if (styleName != null)
          StyleIndex.Add(styleName, aStyle);
      }
  }
}