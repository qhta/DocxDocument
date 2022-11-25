namespace DocumentModel.Math;

/// <summary>
/// Superscript Function.
/// </summary>
public interface ISuperscript // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Superscript Properties.
  /// </summary>
  public DocumentModel.Math.ISuperscriptProperties? SuperscriptProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
  /// <summary>
  /// Superscript (Superscript function).
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? SuperArgument { get ; set; }
  
}
