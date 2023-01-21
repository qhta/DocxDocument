namespace DocumentModel.OpenXml;

public static class NumIdConverter
{
  public static NumId? GetValue(DX.HexBinaryValue? element)
  {
    if (element?.Value != null)
      return element.Value;
    return null;
  }

  public static NumId? GetValue(DXW.LongHexNumberType? element)
  {
    if (element?.Val?.Value != null)
      return element.Val.Value;
    return null;
  }

  public static DX.HexBinaryValue? CreateHexBinaryValue(NumId? value)
  {
    if (value != null) return new DX.HexBinaryValue(value);
    return null;
  }

  public static HexBinaryType? CreateValue<HexBinaryType>(NumId? value)
    where HexBinaryType : DXW.LongHexNumberType, new()
  {
    if (value != null)
    {
      var element = new HexBinaryType();
      element.Val = new DX.HexBinaryValue(value);
      return element;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(NumId? value)
    where OpenXmlElementType : DX.OpenXmlElement, new()
  {
    var newValue = new DX.HexBinaryValue(value);
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, newValue);
    return element;
  }
}