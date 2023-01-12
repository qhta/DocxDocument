namespace DocumentModel.OpenXml;

public static class HexBinaryConverter
{
  public static byte[] GetValue(DocumentFormat.OpenXml.TypedOpenXmlLeafElement element)
  {
    var valProperty = element.GetType().GetProperty("Val");
    if (valProperty != null)
    {
      string? value = (string?)valProperty.GetValue(element);
      if (value != null)
        return Convert.FromHexString(value);
    }
    return new byte[0];
  }

  public static byte[] GetValue(string value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return new byte[0];
  }
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[] value)
    where OpenXmlElementType : DocumentFormat.OpenXml.OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, Convert.ToHexString(value));
    return element;
  }

}