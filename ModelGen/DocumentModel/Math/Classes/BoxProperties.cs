namespace DocumentModel.Math;


/// <summary>
///   Box Properties.
/// </summary>
public partial class BoxProperties
{
  
  /// <summary>
  ///   Operator Emulator.
  /// </summary>
  public DocumentModel.Math.BooleanValues? OperatorEmulator { get; set; }
  
  
  /// <summary>
  ///   No Break.
  /// </summary>
  public DocumentModel.Math.BooleanValues? NoBreak { get; set; }
  
  
  /// <summary>
  ///   Differential.
  /// </summary>
  public DocumentModel.Math.BooleanValues? Differential { get; set; }
  
  
  /// <summary>
  ///   Break.
  /// </summary>
  public DocumentModel.Math.Break? Break { get; set; }
  
  
  /// <summary>
  ///   Alignment.
  /// </summary>
  public DocumentModel.Math.BooleanValues? Alignment { get; set; }
  
  
  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
}
