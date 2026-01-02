using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Qhta.Xml;
namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines Styles.
/// </summary>
//[XmlContentProperty("LatentStyleExceptions")]
public partial class LatentStyles : ObservableCollection<LatentStyleExceptionInfo>//, IDictionary<string, LatentStyleExceptionInfo>
{
  public Dictionary<string, LatentStyleExceptionInfo> StyleIndex = null!;
  public LatentStyles()
  {
    StyleIndex = new();
    CollectionChanged += Styles_CollectionChanged;
  }
  [XmlIgnore]
  public new Collection<LatentStyleExceptionInfo>? Items
  {
    get => this;
    set
    {
      if (value!=null)
        foreach (var item in value)
          Add(item);
    }
  }
  public void Add(string key, LatentStyleExceptionInfo value)
  {
    (StyleIndex).Add(key, value);
  }
  public bool ContainsKey(string key)
  {
    return (StyleIndex).ContainsKey(key);
  }
  public bool Remove(string key)
  {
    return (StyleIndex).Remove(key);
  }
  public bool TryGetValue(string key, [MaybeNullWhen(false)] out LatentStyleExceptionInfo value)
  {
    return (StyleIndex).TryGetValue(key, out value);
  }
  public LatentStyleExceptionInfo this[string key]
  {
    get => (StyleIndex)[key];
    set => (StyleIndex)[key] = value;
  }
  public ICollection<string> Keys => ((IDictionary<string, LatentStyleExceptionInfo>)StyleIndex).Keys;
  public ICollection<LatentStyleExceptionInfo> Values => ((IDictionary<string, LatentStyleExceptionInfo>)StyleIndex).Values;
  public void Add(KeyValuePair<string, LatentStyleExceptionInfo> item)
  {
    ((ICollection<KeyValuePair<string, LatentStyleExceptionInfo>>)StyleIndex).Add(item);
  }
  public bool Contains(KeyValuePair<string, LatentStyleExceptionInfo> item)
  {
    return (StyleIndex).Contains(item);
  }
  public void CopyTo(KeyValuePair<string, LatentStyleExceptionInfo>[] array, int arrayIndex)
  {
    ((ICollection<KeyValuePair<string, LatentStyleExceptionInfo>>)StyleIndex).CopyTo(array, arrayIndex);
  }
  public bool Remove(KeyValuePair<string, LatentStyleExceptionInfo> item)
  {
    return ((ICollection<KeyValuePair<string, LatentStyleExceptionInfo>>)StyleIndex).Remove(item);
  }
  //IEnumerator<KeyValuePair<string, LatentStyleExceptionInfo>> IEnumerable<KeyValuePair<string, LatentStyleExceptionInfo>>.GetEnumerator()
  //{
  //  return (StyleIndex).GetEnumerator();
  //}
  private void Styles_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    switch (args.Action)
    {
      case NotifyCollectionChangedAction.Reset:
        foreach (var item in StyleIndex)
        {
          var LatentStyleExceptionInfo = item.Value;
          LatentStyleExceptionInfo.PropertyChanging -= Item_PropertyChanging;
          LatentStyleExceptionInfo.PropertyChanged -= Item_PropertyChanged;
        }
        StyleIndex.Clear();
        break;
      case NotifyCollectionChangedAction.Add:
        if (args.NewItems != null)
          foreach (var newStyle in args.NewItems.Cast<LatentStyleExceptionInfo>())
          {
            if (newStyle.Name != null)
              StyleIndex.Add(newStyle.Name, newStyle);
            newStyle.PropertyChanging += Item_PropertyChanging;
            newStyle.PropertyChanged += Item_PropertyChanged;
          }
        break;
      case NotifyCollectionChangedAction.Remove:
        if (args.OldItems != null)
          foreach (var oldStyle in args.OldItems.Cast<LatentStyleExceptionInfo>())
          {
            oldStyle.PropertyChanging -= Item_PropertyChanging;
            oldStyle.PropertyChanged -= Item_PropertyChanged;
            if (oldStyle.Name != null)
              StyleIndex.Remove(oldStyle.Name);
          }
        break;
    }
  }
  private void Item_PropertyChanging(object? sender, PropertyChangingEventArgs args)
  {
    if (sender is LatentStyleExceptionInfo aStyle)
      if (args.PropertyName == nameof(LatentStyleExceptionInfo.StyleName))
      {
        var styleName = aStyle.StyleName;
        if (styleName != null)
          StyleIndex.Remove(styleName);
      }
  }
  private void Item_PropertyChanged(object? sender, PropertyChangedEventArgs args)
  {
    if (sender is LatentStyleExceptionInfo aStyle)
      if (args.PropertyName == nameof(LatentStyleExceptionInfo.StyleName))
      {
        var styleName = aStyle.StyleName;
        if (styleName != null)
          StyleIndex.Add(styleName, aStyle);
      }
  }
}