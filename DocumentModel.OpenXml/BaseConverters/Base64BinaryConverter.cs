namespace DocumentModel.OpenXml;

public static class Base64BinaryConverter
{
  public static byte[] GetValue(DX.TypedOpenXmlLeafElement element)
  {
    var valProperty = element.GetType().GetProperty("Normal");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
        return Convert.FromBase64String(value);
    }
    return new byte[0];
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[] value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Normal");
    if (valProperty != null)
      valProperty.SetValue(element, Convert.ToBase64String(value));
    return element;
  }
}