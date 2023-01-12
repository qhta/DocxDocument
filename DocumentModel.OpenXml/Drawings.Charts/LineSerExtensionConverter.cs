namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the LineSerExtension Class.
/// </summary>
public static class LineSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  public static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  public static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }
  
  public static DocumentModel.Drawings.Charts.FilteredSeriesTitle? GetFilteredSeriesTitle(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredSeriesTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFilteredSeriesTitle(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement, DocumentModel.Drawings.Charts.FilteredSeriesTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredSeriesTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredCategoryTitle? GetFilteredCategoryTitle(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredCategoryTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetFilteredCategoryTitle(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement, DocumentModel.Drawings.Charts.FilteredCategoryTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.FilteredCategoryTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabelsRange? GetDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsRangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement, DocumentModel.Drawings.Charts.DataLabelsRange? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelsRangeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.CategoryFilterExceptions? GetCategoryFilterExceptions(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryFilterExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetCategoryFilterExceptions(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement, DocumentModel.Drawings.Charts.CategoryFilterExceptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.CategoryFilterExceptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.LineSerExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.LineSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.LineSerExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.LineSerExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      return openXmlElement;
    }
    return default;
  }
}
