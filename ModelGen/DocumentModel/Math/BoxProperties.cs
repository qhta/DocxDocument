namespace DocumentModel.Math;


/// <summary>
///   Box Properties.
/// </summary>
public partial class BoxProperties
{
  
  /// <summary>
  ///   Operator Emulator.
  /// </summary>
  public DocumentModel.Math.OperatorEmulator? OperatorEmulator { get; set; }
  
  
  /// <summary>
  ///   No Break.
  /// </summary>
  public DocumentModel.Math.NoBreak? NoBreak { get; set; }
  
  
  /// <summary>
  ///   Differential.
  /// </summary>
  public DocumentModel.Math.Differential? Differential { get; set; }
  
  
  /// <summary>
  ///   Break.
  /// </summary>
  public DocumentModel.Math.Break? Break { get; set; }
  
  
  /// <summary>
  ///   Alignment.
  /// </summary>
  public DocumentModel.Math.Alignment? Alignment { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
