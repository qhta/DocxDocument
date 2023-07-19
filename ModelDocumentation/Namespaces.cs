using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

namespace ModelDocumentation;

/// <summary>
/// Collection of <see cref="NamespaceDoc"/> with indexing by name.
/// </summary>
public class Namespaces : ObservableCollection<NamespaceDoc>
{
  private readonly Dictionary<string, NamespaceDoc> _Index;

  /// <summary>
  /// Default initializing constructor.
  /// </summary>
  public Namespaces()
  {
    _Index = new Dictionary<string, NamespaceDoc>();
    this.CollectionChanged += NamespaceCollection_CollectionChanged;
  }

  private void NamespaceCollection_CollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
  {
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
      if (args.NewItems != null)
        foreach (var item in args.NewItems.Cast<NamespaceDoc>())
          _Index.Add(item.Name, item);
    }
  }

  /// <summary>
  /// Checks if an item with the same name was already added.
  /// </summary>
  /// <param name="name"></param>
  /// <returns></returns>
  public bool ContainsKey(string name) => _Index.ContainsKey(name);

  /// <summary>
  /// Tries to get an item with a known name.
  /// </summary>
  /// <param name="name"></param>
  /// <param name="value"></param>
  /// <returns></returns>
  public bool TryGetValue(string name, [NotNullWhen(true)] out NamespaceDoc value) => _Index.TryGetValue(name, out value);

}
