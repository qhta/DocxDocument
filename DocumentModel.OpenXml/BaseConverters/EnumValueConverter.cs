namespace DocumentModel.OpenXml;

public static class EnumValueConverter
{
  public static ModelEnumType? GetValue<OpenXmlEnumType, ModelEnumType>(EnumValue<OpenXmlEnumType>? element)
    where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (element?.Value != null)
    {
      int n = (int)Convert.ChangeType(element.Value, typeof(int));
      var result = (ModelEnumType)Enum.ToObject(typeof(ModelEnumType), n);
      return result;
    }
    return null;
  }

  //public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>(ModelEnumType? value) 
  //  where OpenXmlElementType : EnumValue<OpenXmlEnumType>, new() where OpenXmlEnumType : struct, IConvertible
  //  where ModelEnumType : struct, IConvertible
  //{
  //  if (value != null)
  //  {
  //    var element = new OpenXmlElementType();
  //    int n = (int)Convert.ChangeType(value, typeof(int));
  //    var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
  //    element.Value = val;
  //    return element;
  //  }
  //  return null;
  //}

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>(ModelEnumType? value)
    where OpenXmlElementType : OpenXmlLeafElement, new() where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      int n = (int)Convert.ChangeType(value, typeof(int));
      var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
      //if (typeof(OpenXmlElementType) == typeof(EnumValue<OpenXmlEnumType>))
      //{
      //  element.Value = val;

      //}
      //else
      //{
      var valueProperty = typeof(OpenXmlElementType).GetProperty("Value");
      if (valueProperty == null)
        valueProperty = typeof(OpenXmlElementType).GetProperty("Val");
      if (valueProperty == null)
        valueProperty = typeof(OpenXmlElementType).GetProperties().FirstOrDefault(item=>item.PropertyType==typeof(OpenXmlEnumType));
      if (valueProperty == null || valueProperty.PropertyType != typeof(OpenXmlEnumType))
        throw new InvalidOperationException($"Type \"{typeof(OpenXmlElementType)}\" does not have a property of \"{typeof(OpenXmlEnumType)}\" type");
      if (valueProperty != null)
        valueProperty.SetValue(element, val);
      return element;
    }
    return null;
  }

}