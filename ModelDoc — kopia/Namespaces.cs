using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

namespace ModelDoc;

/// <summary>
/// Collection of <see cref="Namespace"/> with indexing by name.
/// </summary>
public class Namespaces : ObservableCollection<Namespace>
{
  private readonly Dictionary<string, Namespace> _Index;

  /// <summary>
  /// Default initializing constructor.
  /// </summary>
  public Namespaces()
  {
    _Index = new Dictionary<string, Namespace>();
    this.CollectionChanged += NamespaceCollection_CollectionChanged;
  }

  private void NamespaceCollection_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
      if (args.NewItems != null)
        foreach (var item in args.NewItems.Cast<Namespace>())
          _Index.Add(item.FullName, item);
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
  public bool TryGetValue(string name, [NotNullWhen(true)] out Namespace? value) => _Index.TryGetValue(name, out value);

}
