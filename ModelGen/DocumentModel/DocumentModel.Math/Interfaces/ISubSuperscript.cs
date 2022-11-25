namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public interface ISubSuperscript // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  public DocumentModel.Math.ISubSuperscriptProperties? SubSuperscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
  /// <summary>
  /// Subscript (Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? SubArgument { get ; set; }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? SuperArgument { get ; set; }
  
}
