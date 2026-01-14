using System.Xml.Linq;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.EMMA;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlLeafTextElement object.
/// </summary>
public static class EnumValueUtils
{
  /// <summary>
  /// Converts the specified OpenXml EnumValue wrapper to a target Enum type.
  /// </summary>
  /// <typeparam name="EnumType">The target Enum type.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The source OpenXml Enum type.</typeparam>
  /// <param name="enumValue">The OpenXml EnumValue to convert.</param>
  /// <returns>The converted Enum value, or null if conversion fails.</returns>
  public static EnumType? EnumValueToEnumType<EnumType, OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType> enumValue) where EnumType : struct
    where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    var value = enumValue.Value;
    var openXmlEnumType = typeof(OpenXmlEnumType);
    if (typeof(OpenXmlEnumType) != typeof(EnumType))
    {
      if (value is IConvertible)
      {
        var n = (int)Convert.ChangeType(value, typeof(int));
        var newValue = Enum.ToObject(typeof(EnumType), n);
        return (EnumType)newValue;
      }
      else
      {
        var property = openXmlEnumType.GetProperties(BindingFlags.Static | BindingFlags.Public).FirstOrDefault(prop => value.Equals(prop.GetValue(null)));
        if (property != null)
        {
          var s = property.Name;
          var k = s.IndexOf(' ');
          if (k > 0)
            s = s.Substring(0, k);
          var newValue = Enum.Parse(typeof(EnumType), s, true);
          return (EnumType)newValue;
        }
      }
    }
    return null;
  }

  /// <summary>
  /// Converts a standard Enum value to an OpenXml EnumValue wrapper.
  /// </summary>
  /// <typeparam name="EnumType">The source Enum type.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The target OpenXml Enum type.</typeparam>
  /// <param name="value">The Enum value to convert.</param>
  /// <returns>A new OpenXml EnumValue containing the converted value, or null if conversion fails.</returns>
  public static EnumValue<OpenXmlEnumType>? EnumTypeToEnumValue<EnumType, OpenXmlEnumType>(EnumType value) where EnumType : struct where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    var s = value.ToString();
    OpenXmlEnumType? newValue = null;
    var openXmlEnumType = typeof(OpenXmlEnumType);
    if (s != null)
    {
      var property = openXmlEnumType.GetProperty(s, BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);
      if (property != null)
        newValue = property.GetValue(null) as OpenXmlEnumType?;
      else
      {
        var field = openXmlEnumType.GetField(s, BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);
        if (field != null)
          newValue = field.GetValue(null) as OpenXmlEnumType?;
      }
    }
    if (newValue != null)
    {
      var enumValue = new EnumValue<OpenXmlEnumType>(newValue);
      return enumValue;
    }
    return null;
  }

  /// <summary>
  /// Retrieves the Enum value from an OpenXml EnumValue object.
  /// </summary>
  /// <typeparam name="EnumType">The target Enum type.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The source OpenXml Enum type.</typeparam>
  /// <param name="element">The OpenXml EnumValue element.</param>
  /// <returns>The converted Enum value.</returns>
  public static EnumType? GetEnumValue<EnumType, OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType> element) where EnumType : struct
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    var value = (OpenXmlEnumType)element.Value;
    return EnumValueToEnumType<EnumType, OpenXmlEnumType>(value);
  }

  /// <summary>
  /// Sets an Enum value on a specified property of an object using reflection.
  /// </summary>
  /// <typeparam name="EnumType">The source Enum type.</typeparam>
  /// <typeparam name="OpenXmlEnumType">The target OpenXml Enum type expected by the property.</typeparam>
  /// <param name="element">The object containing the property.</param>
  /// <param name="propName">The name of the property to set.</param>
  /// <param name="value">The Enum value to set. If null, the default value is set.</param>
  /// <exception cref="ArgumentException">Thrown if the property is not found on the object.</exception>
  public static void SetEnumValue<EnumType, OpenXmlEnumType>(object element, string propName, EnumType? value) where EnumType : struct
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    var propInfo = element.GetType().GetProperty(propName);
    if (propInfo == null)
      throw new ArgumentException($"Property '{propName}' not found on type '{element.GetType().FullName}'");
    if (value != null)
    {
      var enumValue = EnumTypeToEnumValue<EnumType, OpenXmlEnumType>(value.Value);
      propInfo.SetValue(element, enumValue);
    }
    else
      propInfo.SetValue(element, default(OpenXmlEnumType));
  }

  /// <summary>
  /// Sets a value on an OpenXmlSimpleValue element derived from an Enum, converting types if necessary.
  /// </summary>
  /// <typeparam name="EnumType">The source Enum type.</typeparam>
  /// <typeparam name="EnumType2">The underlying type of the OpenXmlSimpleValue.</typeparam>
  /// <param name="element">The OpenXmlSimpleValue element to update.</param>
  /// <param name="value">The Enum value to set.</param>
  public static void SetSimpleEnumValue<EnumType, EnumType2>(this DX.OpenXmlSimpleValue<EnumType2> element, EnumType? value) where EnumType : struct
  where EnumType2 : struct
  {
    if (value != null)
    {
      var n = (int)Convert.ChangeType(value, typeof(int));
      EnumType2 newValue = (EnumType2)Enum.ToObject(typeof(EnumType2), n);
      element.Value = newValue;
    }
    else
      element.Value = default(EnumType2);
  }
}
