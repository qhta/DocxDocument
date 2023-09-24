namespace DocumentModel.Math;


/// <summary>
///   Box Properties.
/// </summary>
public partial class BoxProperties
{
  
  /// <summary>
  ///   Operator Emulator.
  /// </summary>
  public Boolean? OperatorEmulator { get; set; }
  
  
  /// <summary>
  ///   No Break.
  /// </summary>
  public Boolean? NoBreak { get; set; }
  
  
  /// <summary>
  ///   Differential.
  /// </summary>
  public Boolean? Differential { get; set; }
  
  
  /// <summary>
  ///   Break.
  /// </summary>
  public Break? Break { get; set; }
  
  
  /// <summary>
  ///   Alignment.
  /// </summary>
  public Boolean? Alignment { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
  
}
