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
  public DocumentModel.Math.IBase? Base { get ; set; }
  
  /// <summary>
  /// Subscript (Sub-Superscript).
  /// </summary>
  public DocumentModel.Math.ISubArgument? SubArgument { get ; set; }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  public DocumentModel.Math.ISuperArgument? SuperArgument { get ; set; }
  
}
