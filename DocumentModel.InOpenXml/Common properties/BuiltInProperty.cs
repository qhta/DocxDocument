using DocumentModel.Properties;

namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
[XmlRoot("BuiltInProperty", Namespace = "DocumentModel")]
public partial class BuiltInProperty : DocumentProperty, DMPr.IDocumentProperty
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
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public object? BaseObject { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the property model associated with this instance.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public PropertyInfo? PropertyInfo { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public override String? Value
  {
    get
    {
      if (PropertyInfo == null)
        return base.Value;
      return GetAttachedPropertyInfo();
    }
    set
    {
      base.Value = value;
      if (PropertyInfo != null)
        SetAttachedPropertyValue(value);
    }
  }

  /// <summary>
  /// Sets the value of the built-in property using the provided string value.
  /// The method converts the string value to the appropriate type based on the PropertyInfo and sets it on the BaseObject.
  /// If the conversion or setting of the value fails, an InvalidOperationException is thrown with details about the failure.
  /// </summary>
  /// <param name="value">The string value to set for the built-in property.</param>
  /// <exception cref="InvalidOperationException">Thrown when the conversion or setting of the value fails.</exception>
  internal void SetAttachedPropertyValue(string? value)
  {
    if (PropertyInfo != null)
    {
      try
      {
        var docPropertyType = PropertyInfo.PropertyType!.ConvertToDocPropertyType();
        var valueObject = docPropertyType.ConvertStringToObject(value, PropertyInfo.PropertyType);
        PropertyInfo?.SetValue(BaseObject, valueObject); //(value as Variant) ?? new Variant(value));
      }
      catch (Exception e)
      {
        throw new InvalidOperationException(
          $"Failed to set the value of the built-in property '{PropertyInfo?.Name}'.", e);
      }
    }
  }

  /// <summary>
  /// Gets the value of the built-in property as a string by retrieving the value from the BaseObject using the PropertyInfo and converting it to a string representation.
  /// </summary>
  /// <returns>The string representation of the built-in property's value.</returns>
  /// <exception cref="InvalidOperationException">Thrown when the conversion or retrieval of the value fails.</exception>
  internal string? GetAttachedPropertyInfo()
  {
    if (PropertyInfo != null)
    {
      try
      {
        var valueObject = PropertyInfo.GetValue(BaseObject);
        var docPropertyType = PropertyInfo.PropertyType!.ConvertToDocPropertyType();
        var valueString = docPropertyType.ConvertObjectToString(valueObject);
        return valueString;
      } catch (Exception e)
      {
        throw new InvalidOperationException($"Failed to get the value of the built-in property '{PropertyInfo?.Name}'.",
          e);
      }
    }
    return null;
  }

  /// <summary>
  /// Type of the property value. For built-in document properties, this property is read-only and returns the type of the property as defined in the PropertyInfo. Setting this property to a different type will throw an exception, as the type of built-in document property cannot be changed.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public override DMPr.DocPropertyType Type
  {
    get { return PropertyInfo?.PropertyType?.ConvertToDocPropertyType() ?? base.Type; }
    set { base.Type = value; }
  }
}