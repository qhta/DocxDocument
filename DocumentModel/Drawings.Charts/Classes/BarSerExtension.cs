namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the BarSerExtension Class.
/// </summary>
public partial class BarSerExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.InvertSolidFillFormat? InvertSolidFillFormat { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  
  public DocumentModel.Drawings.Charts.FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  
  public DocumentModel.Drawings.Charts.DataLabelsRange? DataLabelsRange { get; set; }
  
  public DocumentModel.Drawings.Charts.CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
  
}
