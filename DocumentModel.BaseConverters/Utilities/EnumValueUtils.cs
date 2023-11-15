namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlLeafTextElement object.
/// </summary>
public static class EnumValueUtils
{
  /// <summary>
  /// Gets an enum type value from the specified OpenXml EnumValue&lt;EnumValuesType&gt; parameter.
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="EnumValuesType"></typeparam>
  /// <param name="element"></param>
  /// <returns></returns>
  public static EnumType GetEnumValue<EnumType, EnumValuesType>(this DX.EnumValue<EnumValuesType> element) where EnumType : struct
  where EnumValuesType : struct
  {
    object value = element.Value;
    if (typeof(EnumValuesType) != typeof(EnumType))
    {
      var n = (int)Convert.ChangeType(value, typeof(int));
      value = Enum.ToObject(typeof(EnumType), n);
    }
    return (EnumType)value;
  }

  /// <summary>
  /// Creates an instance of the specified OpenXml EnumValue&lt;EnumValuesType&gt; type parameter
  /// and sets an enum type value to this instance.  
  /// </summary>
  /// <typeparam name="EnumType"></typeparam>
  /// <typeparam name="EnumValuesType"></typeparam>
  /// <param name="value"></param>
  /// <returns></returns>
  public static DX.EnumValue<EnumValuesType>? SetEnumValue<EnumType, EnumValuesType>(this EnumType? value) where EnumType : struct
  where EnumValuesType : struct
  {
    if (value == null)
      return null;
    object? newValue;
    if (typeof(EnumValuesType) != typeof(EnumType))
    {
      var n = (int)Convert.ChangeType(value, typeof(int));
      newValue = Enum.ToObject(typeof(EnumValuesType), n);
    }
    else
      newValue = value;
    return new DX.EnumValue<EnumValuesType>((EnumValuesType)newValue);
  }

}
