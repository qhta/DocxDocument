namespace DocumentModel.Math;

/// <summary>
/// Box Properties.
/// </summary>
public interface IBoxProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IBreak? Break { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public BooleanKind? Alignment { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
