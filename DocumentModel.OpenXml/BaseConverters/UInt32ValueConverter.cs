using System.Globalization;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml;

public static class UInt32ValueConverter
{
  public static UInt32? GetValue(UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static UInt32? GetValue(DocumentFormat.OpenXml.Office2016.Drawing.Charts.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static UInt32? GetValue(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.UnsignedIntegerType element)
  {
    return element.Val?.Value;
  }

  public static UInt32? GetValue(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType element)
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