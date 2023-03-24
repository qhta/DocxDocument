namespace DocumentModel.Math;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Sub-Superscript Properties.
/// </summary>
public class SubSuperscriptProperties: ModelElement
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