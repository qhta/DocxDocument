namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the RegionLabelLayout Class.
/// </summary>
public class RegionLabelLayout: IRegionLabelLayout
{
  /// <summary>
  /// val, this property is only available in Office 2016 and later.
  /// </summary>
  public RegionLabelLayoutEnum? Val
  {
    get;
    set;
  }
  
}
