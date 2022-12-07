namespace DocumentModel.Math;

/// <summary>
/// Box Properties.
/// </summary>
public interface BoxProperties
{
  /// <summary>
  /// Operator Emulator.
  /// </summary>
  public BooleanKind? OperatorEmulator { get ; set; }
  
  /// <summary>
  /// No Break.
  /// </summary>
  public BooleanKind? NoBreak { get ; set; }
  
  /// <summary>
  /// Differential.
  /// </summary>
  public BooleanKind? Differential { get ; set; }
  
  /// <summary>
  /// Break.
  /// </summary>
  public Break? Break { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public BooleanKind? Alignment { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get ; set; }
  
}
