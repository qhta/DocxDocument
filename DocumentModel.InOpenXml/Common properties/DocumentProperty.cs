namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public abstract partial class DocumentProperty : NamedModelElement
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  protected DocumentProperty() { }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public virtual object? Value { get; set; }

  /// <summary>
  ///   Expected value type
  /// </summary>
  public virtual Type? Type { get; set; }
}