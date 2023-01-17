namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public static class NumericLevelConverter
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetPtCount(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement)
  {
    return openXmlElement.PtCount?.Value;
  }
  
  private static void SetPtCount(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement, UInt32? value)
  {
    openXmlElement.PtCount = value;
  }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetFormatCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement)
  {
    return openXmlElement?.FormatCode?.Value;
  }
  
  private static void SetFormatCode(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.FormatCode = new StringValue { Value = value };
    else
      openXmlElement.FormatCode = null;
  }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement)
  {
    return openXmlElement?.Name?.Value;
  }
  
  private static void SetName(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericValue> GetNumericValues(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericValue>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.NumericValueConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetNumericValues(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.NumericValue>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.NumericValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericValue>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumericLevel? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumericLevel();
      value.PtCount = GetPtCount(openXmlElement);
      value.FormatCode = GetFormatCode(openXmlElement);
      value.Name = GetName(openXmlElement);
      value.NumericValues = GetNumericValues(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.NumericLevel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericLevel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPtCount(openXmlElement, value?.PtCount);
      SetFormatCode(openXmlElement, value?.FormatCode);
      SetName(openXmlElement, value?.Name);
      SetNumericValues(openXmlElement, value?.NumericValues);
      return openXmlElement;
    }
    return default;
  }
}
