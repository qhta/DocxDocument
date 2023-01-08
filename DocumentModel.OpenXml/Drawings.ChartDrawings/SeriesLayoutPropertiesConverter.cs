namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the SeriesLayoutProperties Class.
/// </summary>
public static class SeriesLayoutPropertiesConverter
{
  /// <summary>
  /// RegionLabelLayout.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum? GetRegionLabelLayout(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetRegionLabelLayout(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties? openXmlElement, DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayout, DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.RegionLabelLayoutEnum, DocumentModel.Drawings.ChartDrawings.RegionLabelLayoutEnum>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
}
