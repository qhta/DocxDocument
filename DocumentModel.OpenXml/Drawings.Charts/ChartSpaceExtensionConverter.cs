namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ChartSpaceExtension Class.
/// </summary>
public static class ChartSpaceExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.PivotOptions? GetPivotOptions(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PivotOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPivotOptions(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement, DocumentModel.Drawings.Charts.PivotOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.PivotOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.SketchOptions? GetSketchOptions(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SketchOptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSketchOptions(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement, DocumentModel.Drawings.Charts.SketchOptions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.SketchOptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.SketchOptions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.PivotSource3? GetPivotSource(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PivotSource3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPivotSource(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension openXmlElement, DocumentModel.Drawings.Charts.PivotSource3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.PivotSource3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.PivotSource>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.ChartSpaceExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ChartSpaceExtension();
      value.Uri = GetUri(openXmlElement);
      value.PivotOptions = GetPivotOptions(openXmlElement);
      value.SketchOptions = GetSketchOptions(openXmlElement);
      value.PivotSource = GetPivotSource(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ChartSpaceExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ChartSpaceExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetPivotOptions(openXmlElement, value?.PivotOptions);
      SetSketchOptions(openXmlElement, value?.SketchOptions);
      SetPivotSource(openXmlElement, value?.PivotSource);
      return openXmlElement;
    }
    return default;
  }
}
