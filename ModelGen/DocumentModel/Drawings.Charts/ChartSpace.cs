namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Chart Space.
/// </summary>
public partial class ChartSpace
{
  
  /// <summary>
  ///   Date1904.
  /// </summary>
  public DMDC.Date1904? Date1904 { get; set; }
  
  
  /// <summary>
  ///   EditingLanguage.
  /// </summary>
  public String? EditingLanguage { get; set; }
  
  
  /// <summary>
  ///   RoundedCorners.
  /// </summary>
  public DMDC.RoundedCorners? RoundedCorners { get; set; }
  
  public Byte? Style { get; set; }
  
  public DMDC.ColorMapOverride? ColorMapOverride { get; set; }
  
  public DMDC.PivotSource? PivotSource { get; set; }
  
  public DMDC.Protection? Protection { get; set; }
  
  public DMDC.Chart? Chart { get; set; }
  
  public DMDC.ShapeProperties? ShapeProperties { get; set; }
  
  public DMDC.TextProperties? TextProperties { get; set; }
  
  public DMDC.ExternalData? ExternalData { get; set; }
  
  public DMDC.PrintSettings? PrintSettings { get; set; }
  
  public DMDC.UserShapesReference? UserShapesReference { get; set; }
  
  public DMDC.ChartSpaceExtensionList? ChartSpaceExtensionList { get; set; }
  
}
