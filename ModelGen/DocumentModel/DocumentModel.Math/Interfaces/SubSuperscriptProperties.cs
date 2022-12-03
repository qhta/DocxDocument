namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public interface SubSuperscriptProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  public BooleanKind? AlignScripts { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get ; set; }
  
}
