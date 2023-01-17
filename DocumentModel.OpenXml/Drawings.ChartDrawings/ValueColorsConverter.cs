namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColors Class.
/// </summary>
public static class ValueColorsConverter
{
  /// <summary>
  /// MinColorSolidColorFillProperties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.MinColorSolidColorFillProperties? GetMinColorSolidColorFillProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MinColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMinColorSolidColorFillProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement, DocumentModel.Drawings.ChartDrawings.MinColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MinColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MidColorSolidColorFillProperties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.MidColorSolidColorFillProperties? GetMidColorSolidColorFillProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MidColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMidColorSolidColorFillProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement, DocumentModel.Drawings.ChartDrawings.MidColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MidColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MidColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// MaxColorSolidColorFillProperties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.MaxColorSolidColorFillProperties? GetMaxColorSolidColorFillProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.MaxColorSolidColorFillPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetMaxColorSolidColorFillProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors openXmlElement, DocumentModel.Drawings.ChartDrawings.MaxColorSolidColorFillProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.MaxColorSolidColorFillPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MaxColorSolidColorFillProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColors? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColors();
      value.MinColorSolidColorFillProperties = GetMinColorSolidColorFillProperties(openXmlElement);
      value.MidColorSolidColorFillProperties = GetMidColorSolidColorFillProperties(openXmlElement);
      value.MaxColorSolidColorFillProperties = GetMaxColorSolidColorFillProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueColors? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMinColorSolidColorFillProperties(openXmlElement, value?.MinColorSolidColorFillProperties);
      SetMidColorSolidColorFillProperties(openXmlElement, value?.MidColorSolidColorFillProperties);
      SetMaxColorSolidColorFillProperties(openXmlElement, value?.MaxColorSolidColorFillProperties);
      return openXmlElement;
    }
    return default;
  }
}
