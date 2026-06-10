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
  public object? BaseObject { get; set; }
  /// <summary>
  /// Gets or sets the property model associated with this instance.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public PropertyInfo? PropertyInfo { get; set; }

  /// <summary>
  ///   Value of the property
  /// </summary>
  public override string? Value
  {
    get
    {
      try
      {
        if (PropertyInfo == null)
          return base.Value;
        var valueObject = PropertyInfo.GetValue(BaseObject);
        var docPropertyType = PropertyInfo.PropertyType!.ConvertToDocPropertyType();
        var valueString = docPropertyType.ConvertObjectToString(valueObject);
        return valueString;
      }
      catch (Exception e)
      {
        throw new InvalidOperationException(
          $"Failed to get the value of the built-in property '{PropertyInfo?.Name}'.", e);
      }
    }
    set
    {
      base.Value = value;
      if (PropertyInfo != null)
      {
        try
        {
          if (PropertyInfo == null)
            return;
          var docPropertyType = PropertyInfo.PropertyType!.ConvertToDocPropertyType();
          var valueObject = docPropertyType.ConvertStringToObject(value);
          PropertyInfo?.SetValue(BaseObject, valueObject); //(value as Variant) ?? new Variant(value));
        }
        catch (Exception e)
        {
          throw new InvalidOperationException(
            $"Failed to set the value of the built-in property '{PropertyInfo?.Name}'.", e);
        }
      }
    }
  }

  /// <summary>
  /// Type of the property value. For built-in document properties, this property is read-only and returns the type of the property as defined in the PropertyInfo. Setting this property to a different type will throw an exception, as the type of built-in document property cannot be changed.
  /// </summary>
  [XmlIgnore]
  [JsonIgnore]
  [NotMapped]
  public override DMPr.DocPropertyType Type
  {
    get => PropertyInfo?.PropertyType?.ConvertToDocPropertyType() ?? base.Type;
    set => base.Type = value;
  }
}