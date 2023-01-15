using DocumentModel.Drawings.Charts;
using SurfaceSerExtension = DocumentFormat.OpenXml.Drawing.Charts.SurfaceSerExtension;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the SurfaceSerExtension Class.
/// </summary>
public static class SurfaceSerExtensionConverter
{
  /// <summary>
  ///   URI
  /// </summary>
  public static String? GetUri(SurfaceSerExtension? openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }

  public static void SetUri(SurfaceSerExtension? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Uri = new StringValue { Value = value };
      else
        openXmlElement.Uri = null;
  }

  public static FilteredSeriesTitle? GetFilteredSeriesTitle(SurfaceSerExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
    if (itemElement != null)
      return FilteredSeriesTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFilteredSeriesTitle(SurfaceSerExtension? openXmlElement, FilteredSeriesTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredSeriesTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredSeriesTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static FilteredCategoryTitle? GetFilteredCategoryTitle(SurfaceSerExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
    if (itemElement != null)
      return FilteredCategoryTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFilteredCategoryTitle(SurfaceSerExtension? openXmlElement, FilteredCategoryTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FilteredCategoryTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CategoryFilterExceptions? GetCategoryFilterExceptions(SurfaceSerExtension? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
    if (itemElement != null)
      return CategoryFilterExceptionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategoryFilterExceptions(SurfaceSerExtension? openXmlElement, CategoryFilterExceptions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryFilterExceptionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.CategoryFilterExceptions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.SurfaceSerExtension? CreateModelElement(SurfaceSerExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceSerExtension();
      value.Uri = GetUri(openXmlElement);
      value.FilteredSeriesTitle = GetFilteredSeriesTitle(openXmlElement);
      value.FilteredCategoryTitle = GetFilteredCategoryTitle(openXmlElement);
      value.CategoryFilterExceptions = GetCategoryFilterExceptions(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SurfaceSerExtension? value)
    where OpenXmlElementType : SurfaceSerExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetFilteredSeriesTitle(openXmlElement, value?.FilteredSeriesTitle);
      SetFilteredCategoryTitle(openXmlElement, value?.FilteredCategoryTitle);
      SetCategoryFilterExceptions(openXmlElement, value?.CategoryFilterExceptions);
      return openXmlElement;
    }
    return default;
  }
}