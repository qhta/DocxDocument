namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the FilteredCategoryTitle Class.
/// </summary>
public interface FilteredCategoryTitle: IModelElement
{
  /// <summary>
  ///   AxisDataSourceType.
  /// </summary>
  public AxisDataSourceType3? AxisDataSourceType { get; set; }
}