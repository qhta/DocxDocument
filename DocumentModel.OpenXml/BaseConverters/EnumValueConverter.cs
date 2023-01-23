namespace DocumentModel.OpenXml;

public static class EnumValueConverter
{
  public static ModelEnumType? GetValue<OpenXmlEnumType, ModelEnumType>(DX.EnumValue<OpenXmlEnumType>? element)
    where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (element?.Value != null)
    {
      var n = (int)Convert.ChangeType(element.Value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  public static bool CmpValue<OpenXmlEnumType, ModelEnumType>(DX.EnumValue<OpenXmlEnumType>? element, ModelEnumType? value, DiffList? diffs, [CallerMemberName] string? callerName = null)
    where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (element?.Value != null && value != null)
    {
      var n = (int)Convert.ChangeType(element.Value, typeof(int));
      var m = (int)Convert.ChangeType(value, typeof(int));
      if (n == m)
        return true;
      diffs?.Add(callerName, typeof(OpenXmlEnumType).Name, element.Value, value);
      return false;
    }
    if (element?.Value == null && value == null)
      return true;
    diffs?.Add(callerName, typeof(OpenXmlEnumType).Name, element?.Value, value);
    return false;
  }

  public static DX.EnumValue<OpenXmlEnumType>? CreateEnumValue<OpenXmlEnumType, ModelEnumType>(ModelEnumType? value)
    where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var element = new DX.EnumValue<OpenXmlEnumType>();
      var n = (int)Convert.ChangeType(value, typeof(int));
      var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
      element.Value = val;
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>(ModelEnumType? value)
    where OpenXmlElementType : DX.OpenXmlLeafElement, new()
    where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      var n = (int)Convert.ChangeType(value, typeof(int));
      var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
      var valueProperty = typeof(OpenXmlElementType).GetProperty("Value");
      if (valueProperty == null)
        valueProperty = typeof(OpenXmlElementType).GetProperty("Val");
      if (valueProperty == null)
        valueProperty = typeof(OpenXmlElementType).GetProperties().FirstOrDefault(item => item.PropertyType == typeof(OpenXmlEnumType));
      if (valueProperty == null || valueProperty.PropertyType != typeof(OpenXmlEnumType))
        throw new InvalidOperationException($"Type \"{typeof(OpenXmlElementType)}\" does not have a property of \"{typeof(OpenXmlEnumType)}\" type");
      if (valueProperty != null)
        valueProperty.SetValue(element, val);
      return element;
    }
    return null;
  }
}