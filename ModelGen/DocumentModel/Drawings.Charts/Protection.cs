namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Protection Class.
/// </summary>
public partial class Protection
{
  
  /// <summary>
  ///   Chart Object.
  /// </summary>
  public DMDC.ChartObject? ChartObject { get; set; }
  
  
  /// <summary>
  ///   Data Cannot Be Changed.
  /// </summary>
  public DMDC.Data? Data { get; set; }
  
  
  /// <summary>
  ///   Formatting.
  /// </summary>
  public DMDC.Formatting? Formatting { get; set; }
  
  
  /// <summary>
  ///   Selection.
  /// </summary>
  public DMDC.Selection? Selection { get; set; }
  
  
  /// <summary>
  ///   User Interface.
  /// </summary>
  public DMDC.UserInterface? UserInterface { get; set; }
  
}
