using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

namespace ModelDocumentation;
public class Types : ObservableCollection<TypeDoc>
{
  private readonly Dictionary<string, TypeDoc> _TagIndex;
  private readonly Dictionary<string, TypeDoc> _NameIndex;
  private readonly Dictionary<(string, string), TypeDoc> _TagAndNameIndex;

  /// <summary>
  /// Default initializing constructor.
  /// </summary>
  public Types()
  {
    _TagIndex = new Dictionary<string, TypeDoc>();
    _NameIndex = new Dictionary<string, TypeDoc>();
    _TagAndNameIndex = new Dictionary<(string, string), TypeDoc>();
    this.CollectionChanged += NamespaceCollection_CollectionChanged;
  }

  private void NamespaceCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
      if (args.NewItems != null)
        foreach (var item in args.NewItems.Cast<TypeDoc>())
        {
          if (!_TagIndex.ContainsKey(item.Tag))
            _TagIndex.Add(item.Tag, item);
          if (item.Name != null)
          {
            if (!_NameIndex.ContainsKey(item.Name))
              _NameIndex.Add(item.Name, item);
            var key = (item.Tag, item.Name);
            if (!_TagAndNameIndex.ContainsKey(key))
              _TagAndNameIndex.Add(key, item);
          }
        }
    }
  }

  /// <summary>
  /// Checks if an item with the same tag was already added.
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  public bool ContainsTag(string name) => _TagIndex.ContainsKey(name);

  /// <summary>
  /// Tries to get an item with a known tag.
  /// </summary>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public bool TryFindTag(string name, out TypeDoc value) => _TagIndex.TryGetValue(name, out value);

  /// <summary>
  /// Checks if an item with the same name was already added.
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  public bool ContainsName(string name) => _NameIndex.ContainsKey(name);

  /// <summary>
  /// Tries to get an item with a known name.
  /// </summary>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public bool TryFindName(string name,out TypeDoc value) => _NameIndex.TryGetValue(name, out value);

  /// <summary>
  /// Checks if an item with the same tag and name was already added.
  /// </summary>
  /// <param name="tag"></param>
  /// <param name="name"></param>
  /// <returns></returns>
  public bool ContainsTagAndName(string tag, string name) => _TagAndNameIndex.ContainsKey((tag, name));

  /// <summary>
  /// Tries to get an item with known tag and name.
  /// </summary>
  /// <param name="key"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public bool TryFindTagAndName((string, string) key, out TypeDoc value) => _TagAndNameIndex.TryGetValue(key, out value);

}
