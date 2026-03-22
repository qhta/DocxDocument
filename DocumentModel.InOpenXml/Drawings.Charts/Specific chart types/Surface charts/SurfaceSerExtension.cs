namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a surface chart series, providing additional filtering and labeling options.
/// </summary>
[OpenXmlType(typeof(DXDC.SurfaceSerExtension))]
public partial class SurfaceSerExtension: Extension<DXDC.SurfaceSerExtension>
{
  /// <summary>
  ///   Filtered title for the series.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredSeriesTitle))]
  public FilteredSeriesTitle? FilteredSeriesTitle
  {
    get => _FilteredSeriesTitle;
    set => UpdateField(ref _FilteredSeriesTitle, value, nameof(FilteredSeriesTitle));
  }
  private FilteredSeriesTitle? _FilteredSeriesTitle;
  /// <summary>
  ///   Filtered title for the category.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FilteredCategoryTitle))]
  public FilteredCategoryTitle? FilteredCategoryTitle
  {
    get => _FilteredCategoryTitle;
    set => UpdateField(ref _FilteredCategoryTitle, value, nameof(FilteredCategoryTitle));
  }
  private FilteredCategoryTitle? _FilteredCategoryTitle;
  /// <summary>
  ///   Exceptions for category filters applied to the series.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.CategoryFilterExceptions))]
  public CategoryFilterExceptions? CategoryFilterExceptions
  {
    get => _CategoryFilterExceptions;
    set => UpdateField(ref _CategoryFilterExceptions, value, nameof(CategoryFilterExceptions));
  }
  private CategoryFilterExceptions? _CategoryFilterExceptions;
}