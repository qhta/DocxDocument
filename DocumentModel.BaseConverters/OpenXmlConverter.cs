namespace DocumentModel.OpenXml;

public static class OpenXmlConverter
{
  public static object? ConvertToOpenXml(object? value, Type conversionType)
  {
    if (value == null)
      return null;
    if (conversionType.IsSubclassOf(typeof(DX.OpenXmlElement)))
      return OpenXmlElementConverter.ConvertToOpenXml(value, conversionType);
    if (conversionType.IsSubclassOf(typeof(DX.OpenXmlSimpleType)))
      return OpenXmlSimpleValueConverter.ConvertToOpenXml(value, conversionType);
    return Convert.ChangeType(value, conversionType);
  }

  public static object? ConvertFromOpenXml(object? value, Type conversionType)
  {
    if (value == null)
      return null;
    if (value is DX.OpenXmlElement openXmlElement)
      return OpenXmlElementConverter.ConvertFromOpenXml(openXmlElement, conversionType);

    return Convert.ChangeType(value, conversionType);
  }

}