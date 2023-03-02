namespace DocumentModel.Math;

/// <summary>
///   Sub-Superscript Properties.
/// </summary>
public record SubSuperscriptProperties
{
  /// <summary>
  ///   Align Scripts.
  /// </summary>
  public BooleanKind? AlignScripts { get; set; }

  /// <summary>
  ///   ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties { get; set; }
}