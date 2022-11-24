namespace DocumentModel.Math;

/// <summary>
/// Box Properties.
/// </summary>
public interface IBoxProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Operator Emulator.
  /// </summary>
  public IOperatorEmulator? OperatorEmulator { get ; set; }
  
  /// <summary>
  /// No Break.
  /// </summary>
  public INoBreak? NoBreak { get ; set; }
  
  /// <summary>
  /// Differential.
  /// </summary>
  public IDifferential? Differential { get ; set; }
  
  /// <summary>
  /// Break.
  /// </summary>
  public IBreak? Break { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public IAlignment? Alignment { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
