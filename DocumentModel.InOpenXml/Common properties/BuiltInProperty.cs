using DocumentModel.Properties;

namespace DocumentModel;
/// <summary>
///   Abstract document Property.
/// </summary>
[XmlRoot("BuiltInProperty", Namespace = "DocumentModel")]
[JsonConverter(typeof(BuiltInPropertyJsonConverter))]
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
  /// Gets or sets the link target for the property. This property is ignored during XML and JSON serialization, and is not mapped to any database column. It serves as a reference to the target of the property, which can be used for internal linking or referencing within the document model.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public override string? LinkTarget { get => base.LinkTarget; set => base.LinkTarget = value; }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public override object? Value
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
  internal void SetAttachedPropertyValue(object? value)
  {
    if (PropertyInfo != null)
    {
      try
      {
        PropertyInfo?.SetValue(BaseObject, value);
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
  internal object? GetAttachedPropertyInfo()
  {
    if (PropertyInfo != null)
    {
      try
      {
        var valueObject = PropertyInfo.GetValue(BaseObject);
        return valueObject;
      } catch (Exception e)
      {
        throw new InvalidOperationException($"Failed to get the value of the built-in property '{PropertyInfo?.Name}'.",
          e);
      }
    }
    return null;
  }

}