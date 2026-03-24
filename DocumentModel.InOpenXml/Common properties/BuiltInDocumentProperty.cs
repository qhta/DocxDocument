namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
public partial class BuiltInDocumentProperty : DocumentProperty 
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public BuiltInDocumentProperty() { }

  /// <summary>
  /// Object that contains the property. 
  /// </summary>
  public required object BaseObject { get; set; }

  /// <summary>
  /// Gets or sets the property model associated with this instance.
  /// </summary>
  public required PropertyInfo PropertyInfo { get; set; }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public override object? Value
  {
    get => PropertyInfo.GetValue(BaseObject);
    set => PropertyInfo.SetValue(BaseObject, value);
  }
}