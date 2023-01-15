using DocumentModel.Drawings.Charts;
using AxisDataSourceType = DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType;
using FilteredCategoryTitle = DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the FilteredCategoryTitle Class.
/// </summary>
public static class FilteredCategoryTitleConverter
{
  /// <summary>
  ///   AxisDataSourceType.
  /// </summary>
  public static AxisDataSourceType3? GetAxisDataSourceType(FilteredCategoryTitle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AxisDataSourceType>();
    if (itemElement != null)
      return AxisDataSourceType3Converter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAxisDataSourceType(FilteredCategoryTitle? openXmlElement, AxisDataSourceType3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AxisDataSourceType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisDataSourceType3Converter.CreateOpenXmlElement<AxisDataSourceType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.FilteredCategoryTitle? CreateModelElement(FilteredCategoryTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.FilteredCategoryTitle();
      value.AxisDataSourceType = GetAxisDataSourceType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.FilteredCategoryTitle? value)
    where OpenXmlElementType : FilteredCategoryTitle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAxisDataSourceType(openXmlElement, value?.AxisDataSourceType);
      return openXmlElement;
    }
    return default;
  }
}