namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaSerExtension Class.
/// </summary>
public interface AreaSerExtension: Extension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public DataLabelsRange? DataLabelsRange { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}