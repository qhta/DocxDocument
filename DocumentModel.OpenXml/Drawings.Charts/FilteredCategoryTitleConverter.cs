namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the FilteredCategoryTitle Class.
/// </summary>
public static class FilteredCategoryTitleConverter
{
  /// <summary>
  /// AxisDataSourceType.
  /// </summary>
  public static DocumentModel.Drawings.Charts.AxisDataSourceType3? GetAxisDataSourceType(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.AxisDataSourceType3Converter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetAxisDataSourceType(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle? openXmlElement, DocumentModel.Drawings.Charts.AxisDataSourceType3? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.AxisDataSourceType3Converter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.Chart.AxisDataSourceType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.FilteredCategoryTitle? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
