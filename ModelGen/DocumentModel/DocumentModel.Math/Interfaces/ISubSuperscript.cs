namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Function.
/// </summary>
public interface ISubSuperscript // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Sub-Superscript Properties.
  /// </summary>
  public ISubSuperscriptProperties? SubSuperscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
  /// <summary>
  /// Subscript (Sub-Superscript).
  /// </summary>
  public ISubArgument? SubArgument { get ; set; }
  
  /// <summary>
  /// Superscript (Sub-Superscript function).
  /// </summary>
  public ISuperArgument? SuperArgument { get ; set; }
  
}
