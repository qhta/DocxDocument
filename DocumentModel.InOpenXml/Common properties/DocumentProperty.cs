namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public partial class DocumentProperty : NamedModelElement
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public DocumentProperty() { }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public virtual object? Value { get; set; }

  /// <summary>
  ///   Expected value type
  /// </summary>
  public virtual Type? Type { get; set; }
}