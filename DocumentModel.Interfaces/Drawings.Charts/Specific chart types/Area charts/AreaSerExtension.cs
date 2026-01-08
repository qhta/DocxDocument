namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for an area chart series, providing additional filtering and labeling options.
/// </summary>
public interface AreaSerExtension : Extension
{
  /// <summary>
  ///   Filtered title for the series.
  /// </summary>
  public FilteredSeriesTitle? FilteredSeriesTitle { get; set; }

  /// <summary>
  ///   Filtered title for the category.
  /// </summary>
  public FilteredCategoryTitle? FilteredCategoryTitle { get; set; }

  /// <summary>
  ///   Data labels range for the series.
  /// </summary>
  public DataLabelsRange? DataLabelsRange { get; set; }

  /// <summary>
  ///   Exceptions for category filters applied to the series.
  /// </summary>
  public CategoryFilterExceptions? CategoryFilterExceptions { get; set; }
}