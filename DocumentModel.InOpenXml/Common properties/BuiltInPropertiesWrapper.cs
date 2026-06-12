namespace DocumentModel;

/// <summary>
/// Wrapper for BuiltInDocumentProperties to implement IDocumentProperties interface.
/// </summary>
public partial class BuiltInDocumentPropertiesWrapper : DMPr.IDocumentProperties
{

  private readonly BuiltInDocumentProperties _builtInProperties;

  /// <summary>
  /// Initializes a new instance of the <see cref="BuiltInDocumentPropertiesWrapper"/> class that wraps the specified <see cref="BuiltInDocumentProperties"/> instance.
  /// </summary>
  /// <param name="builtInProperties"></param>
  public BuiltInDocumentPropertiesWrapper(BuiltInDocumentProperties builtInProperties)
  {
    _builtInProperties = builtInProperties;
  }

  /// <summary>
  /// Returns an enumerator that iterates through the collection of built-in document properties.
  /// </summary>
  /// <returns></returns>
  public IEnumerator<DMPr.IDocumentProperty> GetEnumerator()
  {
    return _builtInProperties.GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return GetEnumerator();
  }

  /// <summary>
  /// Gets or sets the document property with the specified name. 
  /// </summary>
  /// <param name="Index">The name of the document property.</param>
  /// <returns>The document property with the specified name.</returns>
  public DMPr.IDocumentProperty this[object Index] 
  { 
    get => _builtInProperties[(string)Index]; 
    set => _builtInProperties[(string)Index] = (BuiltInProperty)value;
  }
}
