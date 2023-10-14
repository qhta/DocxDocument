namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Protection Class.
/// </summary>
public partial class Protection
{
  
  /// <summary>
  ///   Chart Object.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartObject? ChartObject { get; set; }
  
  
  /// <summary>
  ///   Data Cannot Be Changed.
  /// </summary>
  public DocumentModel.Drawings.Charts.Data? Data { get; set; }
  
  
  /// <summary>
  ///   Formatting.
  /// </summary>
  public DocumentModel.Drawings.Charts.Formatting? Formatting { get; set; }
  
  
  /// <summary>
  ///   Selection.
  /// </summary>
  public DocumentModel.Drawings.Charts.Selection? Selection { get; set; }
  
  
  /// <summary>
  ///   User Interface.
  /// </summary>
  public DocumentModel.Drawings.Charts.UserInterface? UserInterface { get; set; }
  
}
