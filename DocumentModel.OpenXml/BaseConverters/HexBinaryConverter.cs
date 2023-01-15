namespace DocumentModel.OpenXml;

public static class HexBinaryConverter
{
  public static byte[]? GetValue(TypedOpenXmlLeafElement? element)
  {
    var valProperty = element?.GetType().GetProperty("Val");
    if (valProperty != null)
    {
      var value = (string?)valProperty.GetValue(element);
      if (value != null)
        return Convert.FromHexString(value);
    }
    return null;
  }

  public static byte[]? GetValue(string? value)
  {
    if (value != null)
      return Convert.FromHexString(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(byte[]? value)
    where HexBinaryType : HexBinaryValue, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Value = Convert.ToHexString(value);
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(byte[]? value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    if (value != null)
    {
      var element = new OpenXmlElementType();
      if (value.Length > 0)
      {
        var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
        if (valProperty != null)
          valProperty.SetValue(element, CreateValue<HexBinaryValue>(value));
      }
      return element;
    }
    return null;
  }
}