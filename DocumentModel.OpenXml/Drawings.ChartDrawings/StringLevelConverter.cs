namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringLevel Class.
/// </summary>
public static class StringLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetPtCount(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? openXmlElement)
  {
    return openXmlElement?.PtCount?.Value;
  }
  
  public static void SetPtCount(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  public static void SetName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Name = new StringValue { Value = value };
      else
        openXmlElement.Name = null;
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>? GetChartStringValues(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.ChartStringValueConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetChartStringValues(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.ChartStringValue>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.ChartStringValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartStringValue>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringLevel? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.StringLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.ChartStringValues = GetChartStringValues(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.StringLevel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtCount(openXmlElement, value?.PtCount);
      SetName(openXmlElement, value?.Name);
      SetChartStringValues(openXmlElement, value?.ChartStringValues);
      return openXmlElement;
    }
    return default;
  }
}
