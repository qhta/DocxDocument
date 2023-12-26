namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlLeafTextElement object.
/// </summary>
public static class EnumValueUtils
{
  /// <summary>
  /// Gets an enum type value from the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; parameter.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="element"></param>
  /// <returns></returns>
  public static EnumType GetEnumValue<EnumType, OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType> element) where EnumType : struct
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    object value = element.Value;
    if (typeof(OpenXmlEnumType) != typeof(EnumType))
    {
      var n = (int)Convert.ChangeType(value, typeof(int));
      value = Enum.ToObject(typeof(EnumType), n);
    }
    return (EnumType)value;
  }

  /// <summary>
  /// Creates an instance of the specified OpenXml EnumValue&lt;OpenXmlEnumType&gt; type parameter
  /// and sets an enum type value to this instance.  
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="OpenXmlEnumType"></typeparam>
  /// <param name="value"></param>
  public static void SetEnumValue<EnumType, OpenXmlEnumType>(this DX.EnumValue<OpenXmlEnumType> element, EnumType? value) where EnumType : struct
  where OpenXmlEnumType : struct, IEnumValue, IEnumValueFactory<OpenXmlEnumType>
  {
    if (value != null)
    {
        var n = (int)Convert.ChangeType(value, typeof(int));
        OpenXmlEnumType newValue = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
        element.Value = newValue;
    }
    else
      element.Value = default(OpenXmlEnumType);
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
