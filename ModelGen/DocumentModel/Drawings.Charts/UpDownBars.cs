namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public partial class UpDownBars
{
  
  /// <summary>
  ///   Gap Width.
  /// </summary>
  public DMDC.GapWidth? GapWidth { get; set; }
  
  
  /// <summary>
  ///   Up Bars.
  /// </summary>
  public DMDC.UpBars? UpBars { get; set; }
  
  
  /// <summary>
  ///   Down Bars.
  /// </summary>
  public DMDC.DownBars? DownBars { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DMDC.ExtensionList? ExtensionList { get; set; }
  
}
