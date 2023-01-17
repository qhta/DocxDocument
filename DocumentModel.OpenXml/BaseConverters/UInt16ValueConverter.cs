using System.Globalization;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace DocumentModel.OpenXml;

public static class UInt16ValueConverter
{

  public static UInt16? GetValue(DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType element)
  {
    if (element.Val?.Value != null)
      return UInt16.Parse(element.Val.Value, NumberStyles.HexNumber);
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(UInt16 value)
    where OpenXmlElementType : OpenXmlElement, new()
  {
    var element = new OpenXmlElementType();
    var valProperty = typeof(OpenXmlElementType).GetProperty("Val");
    if (valProperty != null)
      valProperty.SetValue(element, value);
    return element;
  }
}