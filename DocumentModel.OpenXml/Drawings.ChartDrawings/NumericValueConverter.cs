using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the NumericValue Class.
/// </summary>
public static class NumericValueConverter
{
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetIdx(NumericValue? openXmlElement)
  {
    return openXmlElement?.Idx?.Value;
  }

  public static void SetIdx(NumericValue? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Idx = value;
  }

  public static DocumentModel.Drawings.ChartDrawings.NumericValue? CreateModelElement(NumericValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumericValue();
      value.Idx = GetIdx(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.NumericValue? value)
    where OpenXmlElementType : NumericValue, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdx(openXmlElement, value?.Idx);
      return openXmlElement;
    }
    return default;
  }
}