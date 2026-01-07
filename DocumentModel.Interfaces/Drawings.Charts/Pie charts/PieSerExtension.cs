namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the PieSerExtension Class.
/// </summary>
public interface PieSerExtension: Extension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public DataLabelsRange? DataLabelsRange { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}