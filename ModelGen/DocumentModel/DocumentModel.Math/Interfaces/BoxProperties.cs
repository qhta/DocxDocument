namespace DocumentModel.Math;

/// <summary>
/// Box Properties.
/// </summary>
public interface BoxProperties
{
  /// <summary>
  /// Operator Emulator.
  /// </summary>
  public DocumentModel.Math.BooleanKind? OperatorEmulator { get ; set; }
  
  /// <summary>
  /// No Break.
  /// </summary>
  public DocumentModel.Math.BooleanKind? NoBreak { get ; set; }
  
  /// <summary>
  /// Differential.
  /// </summary>
  public DocumentModel.Math.BooleanKind? Differential { get ; set; }
  
  /// <summary>
  /// Break.
  /// </summary>
  public DocumentModel.Math.Break? Break { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public DocumentModel.Math.BooleanKind? Alignment { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
