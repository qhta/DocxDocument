namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the BubbleSerExtension Class.
/// </summary>
public static class BubbleSerExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static void SetUri(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DocumentModel.Drawings.Charts.InvertSolidFillFormat? GetInvertSolidFillFormat(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.InvertSolidFillFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetInvertSolidFillFormat(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement, DocumentModel.Drawings.Charts.InvertSolidFillFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.InvertSolidFillFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Drawing.Charts.InvertSolidFillFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.FilteredCategoryTitle? GetFilteredCategoryTitle(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.FilteredCategoryTitleConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetFilteredCategoryTitle(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement, DocumentModel.Drawings.Charts.FilteredCategoryTitle? value)
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
  
  private static DocumentModel.Drawings.Charts.DataLabelsRange? GetDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.DataLabelsRange>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsRangeConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelsRange(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement, DocumentModel.Drawings.Charts.DataLabelsRange? value)
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
  
  private static DocumentModel.Drawings.Charts.CategoryFilterExceptions? GetCategoryFilterExceptions(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.CategoryFilterExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetCategoryFilterExceptions(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension openXmlElement, DocumentModel.Drawings.Charts.CategoryFilterExceptions? value)
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
  
  public static DocumentModel.Drawings.Charts.BubbleSerExtension? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.BubbleSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.InvertSolidFillFormat = GetInvertSolidFillFormat(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.DataLabelsRange = GetDataLabelsRange(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.BubbleSerExtension? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.BubbleSerExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetInvertSolidFillFormat(openXmlElement, value?.InvertSolidFillFormat);
      SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
      SetDataLabelsRange(openXmlElement, value?.DataLabelsRange);
      SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
      return openXmlElement;
    }
    return default;
  }
}
