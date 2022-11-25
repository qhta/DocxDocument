namespace DocumentModel.Math;

/// <summary>
/// Box Properties.
/// </summary>
public interface IBoxProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public DocumentModel.Math.IBreak? Break { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public DocumentModel.Math.BooleanKind? Alignment { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ControlProperties { get ; set; }
  
}
