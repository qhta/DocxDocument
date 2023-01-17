namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public static class OpenXmlValueColorEndPositionElementConverter
{
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  private static Boolean? GetExtremeValueColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtremeValueColorPosition>();
    return itemElement != null;
  }
  
  private static void SetExtremeValueColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtremeValueColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtremeValueColorPosition();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  private static Double? GetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  private static Double? GetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement openXmlElement, Double? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.OpenXmlValueColorEndPositionElement? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.OpenXmlValueColorEndPositionElement();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.OpenXmlValueColorEndPositionElement? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtremeValueColorPosition(openXmlElement, value?.ExtremeValueColorPosition);
      SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
      SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
      return openXmlElement;
    }
    return default;
  }
}
