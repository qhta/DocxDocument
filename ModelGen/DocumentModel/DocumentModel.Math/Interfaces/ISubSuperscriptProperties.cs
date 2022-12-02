namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public interface ISubSuperscriptProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  public BooleanKind? AlignScripts { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public IControlProperties? ControlProperties { get ; set; }
  
}
