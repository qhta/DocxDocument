using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;

namespace ModelXmlSchema;

/// <summary>
/// Collection of <see cref="SchemaFile"/> with indexing by name.
/// </summary>
public class SchemaFiles : ObservableCollection<SchemaFile>
{
  private readonly Dictionary<string, SchemaFile> _Index;

  /// <summary>
  /// Default initializing constructor.
  /// </summary>
  public SchemaFiles()
  {
    _Index = new Dictionary<string, SchemaFile>();
    this.CollectionChanged += NamespaceCollection_CollectionChanged;
  }

  private void NamespaceCollection_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs args)
  {
    if (args.Action == NotifyCollectionChangedAction.Add)
    {
      if (args.NewItems != null)
        foreach (var item in args.NewItems.Cast<SchemaFile>())
          _Index.Add(item.FileName!, item);
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
  public bool TryGetValue(string name, [NotNullWhen(true)] out SchemaFile? value) => _Index.TryGetValue(name, out value);

}
