using DocumentFormat.OpenXml.Wordprocessing;

namespace DocumentModel.OpenXml;

public static class NumIdConverter
{
  public static NumId? GetValue(HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  public static NumId? GetValue(LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

  public static HexBinaryValue? CreateHexBinaryValue(NumId? value)
  {
    if (value != null) return new HexBinaryValue(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(NumId? value)
    where HexBinaryType : LongHexNumberType, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Val = new HexBinaryValue(value);
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(NumId? value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var newValue = new HexBinaryValue(value);
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }
}