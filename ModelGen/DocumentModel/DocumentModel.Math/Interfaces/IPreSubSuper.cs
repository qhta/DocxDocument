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
  public DocumentModel.Math.ISubArgument? SubArgument { get ; set; }
  
  /// <summary>
  /// Superscript(Pre-Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.ISuperArgument? SuperArgument { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
