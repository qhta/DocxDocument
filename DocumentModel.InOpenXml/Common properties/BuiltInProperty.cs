namespace DocumentModel;

/// <summary>
///   Abstract document Property.
/// </summary>
public partial class BuiltInProperty: DocumentProperty, DMP.IDocumentProperty
{
  /// <summary>
  /// Default constructor needed for serialization.
  /// </summary>
  public BuiltInProperty()
  {
  }

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
    set
    {
      try
      {
        PropertyInfo.SetValue(BaseObject, value); //(value as Variant) ?? new Variant(value));
      }
      catch (Exception e)
      {
        throw new InvalidOperationException($"Failed to set the value of the built-in property '{PropertyInfo.Name}'.", e);
      }
    }
  }

  /// <summary>
  /// Type of the property value. For built-in document properties, this property is read-only and returns the type of the property as defined in the PropertyInfo. Setting this property to a different type will throw an exception, as the type of built-in document property cannot be changed.
  /// </summary>
  public override Type? Type
  {
    get => PropertyInfo.PropertyType;
    set => throw new InvalidOperationException($"The type of the built-property value can't be changed.");
  }
}