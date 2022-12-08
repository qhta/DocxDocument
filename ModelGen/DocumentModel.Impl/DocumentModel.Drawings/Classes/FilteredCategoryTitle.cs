namespace DocumentModel.Drawings;

/// <summary>
/// Defines the FilteredCategoryTitle Class.
/// </summary>
public class FilteredCategoryTitleImpl: ModelElementImpl, FilteredCategoryTitle
{
  public DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.Chart.FilteredCategoryTitle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// AxisDataSourceType.
  /// </summary>
  public AxisDataSourceType2? AxisDataSourceType
  {
    get;
    set;
  }
  
}
