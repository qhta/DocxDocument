
namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlLeafElement object.
/// </summary>
public static class OpenXmlLeafElementUtils
{

  /// <summary>
  /// Retrieves an enum type value from the specified OpenXmlLeafElement parameter
  /// which has an OpenXml EnumValue "Val" property.
  /// </summary>
  /// <typeparam name="EnumType">The target enum type.</typeparam>
  /// <typeparam name="ElementType">The specific OpenXmlLeafElement type.</typeparam>
  /// <param name="_element">The OpenXmlLeafElement instance.</param>
  /// <returns>The converted enum value, or null if retrieval fails.</returns>
  public static EnumType? GetEnumVal<EnumType, ElementType>(this DX.OpenXmlLeafElement _element) where EnumType : struct
  where ElementType : DX.OpenXmlLeafElement
  {
    var valProperty = typeof(ElementType).GetProperty("Val");
    Debug.Assert(valProperty != null, $"\"Val\" property in {typeof(ElementType)} not found");
    var val = valProperty.GetValue(_element);
    if (val != null)
    {
      var valType = val.GetType();
      Debug.Assert(valType.Name.StartsWith("EnumValue`1"), $"\"Val\" property in {typeof(ElementType)} must be EnumValue<>");
      var valueProperty = valType.GetProperty("Value");
      Debug.Assert(valueProperty != null, $"\"Value\" property in {valType} not found");
      var value = valueProperty.GetValue(val);
      if (value != null)
      {
        var valueType = value.GetType();
        if (valueType != typeof(EnumType))
        {
          var n = (int)Convert.ChangeType(value, typeof(int));
          value = Enum.ToObject(typeof(EnumType), n);
        }
        return (EnumType)value;
      }
    }
    return null;
  }

}
