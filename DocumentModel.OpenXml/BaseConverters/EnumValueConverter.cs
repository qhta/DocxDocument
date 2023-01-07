namespace DocumentModel.OpenXml;

public static class EnumValueConverter
{
  public static Nullable<ModelEnumType> GetValue<OpenXmlEnumType, ModelEnumType>(EnumValue<OpenXmlEnumType>? element) 
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType, OpenXmlEnumType, ModelEnumType>(ModelEnumType value) 
    where OpenXmlElementType : EnumValue<OpenXmlEnumType>, new() where OpenXmlEnumType : struct, IConvertible
    where ModelEnumType : struct, IConvertible
  {
    var element = new OpenXmlElementType();
    int n = (int)Convert.ChangeType(value, typeof(int));
    var val = (OpenXmlEnumType)Enum.ToObject(typeof(OpenXmlEnumType), n);
    element.Value = val;
    return element;
  }
}