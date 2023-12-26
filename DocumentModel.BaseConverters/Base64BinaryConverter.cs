namespace DocumentModel.OpenXml;

public static class Base64BinaryConverter
{
  public static byte[]? GetValue(DX.Base64BinaryValue? val)
  {
    if (val == null)
      return null;
    var value = val.Value;
    if (value != null)
      return Convert.FromBase64String(value);
    return new byte[0];
  }

  public static byte[]? GetValue(DX.OpenXmlLeafElement? element)
  {
    if (element == null)
      return null;
    var valProperty = element.GetType().GetProperty("Value");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
        return Convert.FromBase64String(value);
    }
    return new byte[0];
  }

  public static DX.Base64BinaryValue? CreateBase64BinaryValue(byte[]? value)
  {
    if (value == null)
      return null;
    var element = new DX.Base64BinaryValue();
    element.InnerText = Convert.ToBase64String(value);
    return element;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[]? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    if (value == null)
      return null;
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Value");
    if (valProperty != null)
      valProperty.SetValue(element, Convert.ToBase64String(value));
    return element;
  }
}