namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ChartSpaceExtension Class.
/// </summary>
public partial class ChartSpaceExtension
{
  
  /// <summary>
  ///   URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DMDC10.PivotOptions? PivotOptions { get; set; }
  
  public DMDC10.SketchOptions? SketchOptions { get; set; }
  
  public DMDC13.PivotSource? PivotSource { get; set; }
  
}
