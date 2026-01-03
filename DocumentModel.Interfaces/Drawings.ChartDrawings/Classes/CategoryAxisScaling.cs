namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the CategoryAxisScaling Class.
/// </summary>
public interface CategoryAxisScaling: IModelElement
{
  /// <summary>
  ///   gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  public string? GapWidth { get; set; }
}