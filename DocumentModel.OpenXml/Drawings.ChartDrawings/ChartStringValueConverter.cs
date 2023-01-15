using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ChartStringValue Class.
/// </summary>
public static class ChartStringValueConverter
{
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetIndex(ChartStringValue? openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }

  public static void SetIndex(ChartStringValue? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = value;
  }

  public static DocumentModel.Drawings.ChartDrawings.ChartStringValue? CreateModelElement(ChartStringValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartStringValue();
      value.Index = GetIndex(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ChartStringValue? value)
    where OpenXmlElementType : ChartStringValue, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      return openXmlElement;
    }
    return default;
  }
}