namespace DocumentModel.OpenXml;

public static class UInt32ValueConverter
{
  public static UInt32? GetValue(DXDrawCharts.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static UInt32? GetValue(DXO2016DrawCharts.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static UInt32? GetValue(DXO2016DrawChartDraw.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static UInt32? GetValue(DXW.LongHexNumberType element)
  {
    if (element.Val?.Value != null)
      return UInt32.Parse(element.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(UInt32 value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }
}