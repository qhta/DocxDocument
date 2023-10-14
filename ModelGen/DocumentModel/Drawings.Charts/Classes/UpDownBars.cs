namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the UpDownBars Class.
/// </summary>
public partial class UpDownBars
{
  
  /// <summary>
  ///   Gap Width.
  /// </summary>
  public DocumentModel.Drawings.Charts.GapWidth? GapWidth { get; set; }
  
  
  /// <summary>
  ///   Up Bars.
  /// </summary>
  public DocumentModel.Drawings.Charts.UpBars? UpBars { get; set; }
  
  
  /// <summary>
  ///   Down Bars.
  /// </summary>
  public DocumentModel.Drawings.Charts.DownBars? DownBars { get; set; }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawings.Charts.ExtensionList? ExtensionList { get; set; }
  
}
