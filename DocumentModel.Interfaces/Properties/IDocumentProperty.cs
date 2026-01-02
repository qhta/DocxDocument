namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public interface IDocumentProperty: IModelElement, ICollectionItem
{
  /// <summary>
  ///   Property Category.
  /// </summary>
  public string? Category { get; set; }
  /// <summary>
  ///   Property Name.
  /// </summary>
  public string? Name { get; set; }
  /// <summary>
  ///   Value of the property
  /// </summary>
  public object? Value { get; set; }
  /// <summary>
  ///   Expected value type
  /// </summary>
  public Type? Type { get; set; }
}