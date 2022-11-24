namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public interface ISuperscript // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public ISuperscriptProperties? SuperscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public ISuperArgument? SuperArgument { get ; set; }
  
}
