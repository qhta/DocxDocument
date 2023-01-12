namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabelHidden Class.
/// </summary>
public static class DataLabelHiddenConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden? openXmlElement)
  {
    return openXmlElement?.Idx?.Value;
  }
  
  public static void SetIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Idx = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabelHidden? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabelHidden();
      value.Idx = GetIdx(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.DataLabelHidden? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelHidden, new()
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
