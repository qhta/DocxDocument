namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies baseline alignment for Asian text.
/// </summary>
public enum BaselineAlignmentKind
{
  /// <summary>Align to baseline</summary>
  Baseline = 0,
  /// <summary>Align to top</summary>
  Top = 1,
  /// <summary>Align to center</summary>
  Center = 2,
  /// <summary>Align to bottom</summary>
  Bottom = 3,
  /// <summary>Automatic alignment</summary>
  Auto = 4
}