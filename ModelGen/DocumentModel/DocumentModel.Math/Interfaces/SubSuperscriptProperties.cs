namespace DocumentModel.Math;

/// <summary>
/// Sub-Superscript Properties.
/// </summary>
public interface SubSuperscriptProperties
{
  /// <summary>
  /// Align Scripts.
  /// </summary>
  public DocumentModel.Math.BooleanKind? AlignScripts { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
