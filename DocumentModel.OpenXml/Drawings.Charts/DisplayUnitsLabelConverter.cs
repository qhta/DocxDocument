namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Display Units Label.
/// </summary>
public static class DisplayUnitsLabelConverter
{
  /// <summary>
  /// Layout.
  /// </summary>
  public static DocumentModel.Drawings.Charts.Layout? GetLayout(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.LayoutConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetLayout(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement, DocumentModel.Drawings.Charts.Layout? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Layout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.LayoutConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Layout>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartText? GetChartText(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartTextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartText(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartText? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartTextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartText>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartShapeProperties? GetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetChartShapeProperties(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement, DocumentModel.Drawings.Charts.ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public static DocumentModel.Drawings.Charts.TextProperties? GetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetTextProperties(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement, DocumentModel.Drawings.Charts.TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DisplayUnitsLabel? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DisplayUnitsLabel();
      value.Layout = GetLayout(openXmlElement);
      value.ChartText = GetChartText(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DisplayUnitsLabel? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLayout(openXmlElement, value?.Layout);
      SetChartText(openXmlElement, value?.ChartText);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      return openXmlElement;
    }
    return default;
  }
}
