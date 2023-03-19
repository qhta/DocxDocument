namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the LineSerExtension Class.
/// </summary>
public class LineSerExtension: ModelElement
{
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }

  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }

  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }

  public DataLabelsRange? DataLabelsRange { get; set; }

  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}