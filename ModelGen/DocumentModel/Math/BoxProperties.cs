namespace DocumentModel.Math;


/// <summary>
///   Box Properties.
/// </summary>
public partial class BoxProperties
{
  
  /// <summary>
  ///   Operator Emulator.
  /// </summary>
  public DMM.OperatorEmulator? OperatorEmulator { get; set; }
  
  
  /// <summary>
  ///   No Break.
  /// </summary>
  public DMM.NoBreak? NoBreak { get; set; }
  
  
  /// <summary>
  ///   Differential.
  /// </summary>
  public DMM.Differential? Differential { get; set; }
  
  
  /// <summary>
  ///   Break.
  /// </summary>
  public DMM.Break? Break { get; set; }
  
  
  /// <summary>
  ///   Alignment.
  /// </summary>
  public DMM.Alignment? Alignment { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DMM.ControlProperties? ControlProperties { get; set; }
  
}
