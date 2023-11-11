namespace DocumentModel.OpenXml;

/// <summary>
/// This static class contains extension operations to be performed on a OpenXmlLeafTextElement object.
/// </summary>
public static class EnumValueUtils
{
  public static EnumType GetEnumValue<EnumType, EnumValuesType>(this DX.EnumValue<EnumValuesType> _element) where EnumType : struct
  where EnumValuesType : struct
  {
    object value = _element.Value;
    if (typeof(EnumValuesType) != typeof(EnumType))
    {
      var n = (int)Convert.ChangeType(value, typeof(int));
      value = Enum.ToObject(typeof(EnumType), n);
    }
    return (EnumType)value;
  }

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
