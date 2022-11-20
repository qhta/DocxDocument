namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the CategoryAxisScaling Class.
/// </summary>
public class CategoryAxisScaling: ICategoryAxisScaling
{
  /// <summary>
  /// gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  public string? GapWidth
  {
    get;
    set;
  }
  
}
