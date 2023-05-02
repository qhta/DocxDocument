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

  public static bool CmpValue<OpenXmlEnumType, ModelEnumType>(DX.EnumValue<OpenXmlEnumType>? element, ModelEnumType? value,
    DiffList? diffs = null, string? objName = null, string? propName = null)
    where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (element?.Value != null && value != null)
    {
      var n = (int)Convert.ChangeType(element.Value, typeof(int));
      var m = (int)Convert.ChangeType(value, typeof(int));
      if (n == m)
        return true;
      diffs?.Add(objName, propName ?? typeof(OpenXmlEnumType).Name, element.Value, value);
      return false;
    }
    if (element?.Value == null && value == null)
      return true;
    diffs?.Add(objName, propName ?? typeof(OpenXmlEnumType).Name, element?.Value, value);
    return false;
  }

  public static bool CmpValue<ModelEnumType>(ModelEnumType value1, ModelEnumType? value2,
    DiffList? diffs = null, string? objName = null, string? propName = null)
    where ModelEnumType : struct, IConvertible
  {
    if (value2 != null)
    {
      var n = (int)Convert.ChangeType(value1, typeof(int));
      var m = (int)Convert.ChangeType(value2, typeof(int));
      if (n == m)
        return true;
      diffs?.Add(objName, propName, value1, value2);
      return false;
    }
    //if (element?.Value == null && value2 == null)
    //  return true;
    diffs?.Add(objName, propName, value1, value2);
    return false;
  }

  public static ModelEnumType? CreateValue<ModelEnumType>(UInt16? value)
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var n = (int)Convert.ChangeType(value, typeof(int));
      var val = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return val;
    }
    return null;
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>(ModelEnumType value)
  where OpenXmlElementType : DX.OpenXmlLeafElement, new()
  where OpenXmlEnumType : struct, IConvertible
  where ModelEnumType : struct, IConvertible
  {
    var element = new OpenXmlElementType();
    UpdateOpenXmlElement<OpenXmlEnumType, ModelEnumType>(element, value);
    return element;
  }

  public static void UpdateOpenXmlElement<OpenXmlEnumType, ModelEnumType>(DX.OpenXmlLeafElement element, ModelEnumType value)
  where OpenXmlEnumType : struct, IConvertible
  where ModelEnumType : struct, IConvertible
  {
    var n = (int)Convert.ChangeType(value, typeof(int));
    var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
    var valueProperty = element.GetType().GetProperty("Type") ??
      element.GetType().GetProperty("Value") ?? element.GetType().GetProperty("Val");
    //if (valueProperty == null)
    //  valueProperty = element.GetType().GetProperties().FirstOrDefault(item => item.PropertyType == typeof(OpenXmlEnumType));
    if (valueProperty == null /*|| valueProperty.PropertyType != typeof(OpenXmlEnumType)*/)
      throw new InvalidOperationException($"Type \"{element.GetType()}\" does not have a property of \"{typeof(OpenXmlEnumType)}\" type");
    if (valueProperty != null)
      valueProperty.SetValue(element, new DocumentFormat.OpenXml.EnumValue<OpenXmlEnumType>(val));
  }
}