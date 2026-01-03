namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the AreaSerExtension Class.
/// </summary>
public interface AreaSerExtension: IModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public string? Uri { get; set; }
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }
  public DataLabelsRange? DataLabelsRange { get; set; }
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}