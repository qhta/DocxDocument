namespace DocumentModel.Math;

/// <summary>
/// Pre-Sub-Superscript Function.
/// </summary>
public interface IPreSubSuper // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Pre-Sub-Superscript Properties.
  /// </summary>
  public DocumentModel.Math.IPreSubSuperProperties? PreSubSuperProperties { get ; set; }
  
  /// <summary>
  /// Subscript (Pre-Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? SubArgument { get ; set; }
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? SuperArgument { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
}
