using DocumentModel.Drawings.ChartsStyle;
using MarkerLayoutProperties = DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerLayoutProperties;

namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
///   Defines the MarkerLayoutProperties Class.
/// </summary>
public static class MarkerLayoutPropertiesConverter
{
  /// <summary>
  ///   symbol, this property is only available in Office 2013 and later.
  /// </summary>
  public static MarkerStyle? GetSymbol(MarkerLayoutProperties? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle, MarkerStyle>(openXmlElement?.Symbol?.Value);
  }

  public static void SetSymbol(MarkerLayoutProperties? openXmlElement, MarkerStyle? value)
  {
    if (openXmlElement != null)
      openXmlElement.Symbol = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.MarkerStyle, MarkerStyle>(value);
  }

  /// <summary>
  ///   size, this property is only available in Office 2013 and later.
  /// </summary>
  public static Byte? GetSize(MarkerLayoutProperties? openXmlElement)
  {
    return openXmlElement?.Size?.Value;
  }

  public static void SetSize(MarkerLayoutProperties? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
      openXmlElement.Size = value;
  }

  public static DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? CreateModelElement(MarkerLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.MarkerLayoutProperties? value)
    where OpenXmlElementType : MarkerLayoutProperties, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSymbol(openXmlElement, value?.Symbol);
      SetSize(openXmlElement, value?.Size);
      return openXmlElement;
    }
    return default;
  }
}