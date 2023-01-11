namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MaxValueColorEndPosition Class.
/// </summary>
public static class MaxValueColorEndPositionConverter
{
  public static Boolean? GetExtremeValueColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtremeValueColorPosition>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetExtremeValueColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static Double? GetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition");
  }
  
  public static void SetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition");
  }
  
  public static Double? GetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition");
  }
  
  public static void SetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? openXmlElement, Double? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition();
      value.ExtremeValueColorPosition = GetExtremeValueColorPosition(openXmlElement);
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.MaxValueColorEndPosition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxValueColorEndPosition, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
