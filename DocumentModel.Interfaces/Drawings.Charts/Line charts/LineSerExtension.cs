namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineSerExtension Class.
/// </summary>
public interface LineSerExtension: Extension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public DataLabelsRange? DataLabelsRange { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}