namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public interface ISubSuperscriptProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  public DocumentModel.Math.BooleanKind? AlignScripts { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
