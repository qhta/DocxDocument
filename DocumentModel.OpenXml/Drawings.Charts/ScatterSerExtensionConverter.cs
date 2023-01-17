namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the ScatterSerExtension Class.
/// </summary>
public static class ScatterSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.FilteredSeriesTitle? GetFilteredSeriesTitle(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredSeriesTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredSeriesTitle(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredSeriesTitle? value)
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
  
  private static DocumentModel.Drawings.Charts.FilteredCategoryTitle? GetFilteredCategoryTitle(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredCategoryTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredCategoryTitle(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredCategoryTitle? value)
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
  
  private static DocumentModel.Drawings.Charts.DataLabelsRange? GetDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsRangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement, DocumentModel.Drawings.Charts.DataLabelsRange? value)
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
  
  private static DocumentModel.Drawings.Charts.CategoryFilterExceptions? GetCategoryFilterExceptions(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryFilterExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryFilterExceptions(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension openXmlElement, DocumentModel.Drawings.Charts.CategoryFilterExceptions? value)
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
  
  public static DocumentModel.Drawings.Charts.ScatterSerExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ScatterSerExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ScatterSerExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
      SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
      SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
      SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
      return openXmlElement;
    }
    return default;
  }
}
