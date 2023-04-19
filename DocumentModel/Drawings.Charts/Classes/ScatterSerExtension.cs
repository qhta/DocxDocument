namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ScatterSerExtension Class.
/// </summary>
public class ScatterSerExtension: ModelElement
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