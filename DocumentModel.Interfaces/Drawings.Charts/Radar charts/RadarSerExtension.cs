namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RadarSerExtension Class.
/// </summary>
public interface RadarSerExtension: Extension
{
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public DataLabelsRange? DataLabelsRange { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}