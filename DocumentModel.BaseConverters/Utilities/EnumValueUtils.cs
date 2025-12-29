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
  /// Converts the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; parameter to an enum type value.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="enumValue"></param>
  /// <returns></returns>
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
  /// Converts the specified enum type value to an OpenXml EnumValue&lt;OpenXmlEnumType&gt; instance.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
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
  /// Gets an enum type value from the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; parameter.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="element"></param>
  /// <returns></returns>
  public static EnumType? GetEnumValue<EnumType, OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType> element) where EnumType : struct
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    var value = (OpenXmlEnumType)element.Value;
    return EnumValueToEnumType<EnumType, OpenXmlEnumType>(value);
  }

  /// <summary>
  /// Creates an instance of the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; type parameter
  /// and sets an enum type value to this instance.  
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="element">Element to update</param>
  /// <param name="propName">Property to set</param>
  /// <param name="value">Value to set</param>
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
  /// Creates an instance of the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; type parameter
  /// and sets an enum type value to this instance.  
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="EnumType2"></typeparam>
  /// <param name="value"></param>
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
