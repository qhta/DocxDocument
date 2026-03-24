namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the vertical position of fonts on a line.
/// </summary>
public enum WdBaselineAlignment
{
  /// <summary>
  /// Align along top of each font.
  /// </summary>
  Top = 0,
  /// <summary>
  /// Align center points of each font. wdBaselineAlignBaseline2 Align to a baseline for the paragraph.
  /// </summary>
  Center = 1,
  /// <summary>
  /// Specifies the vertical position of fonts on a line.
  /// </summary>
  Baseline = 2,
  /// <summary>
  /// Align using Far East font standards.
  /// </summary>
  FarEast50 = 3,
  /// <summary>
  /// Word automatically adjusts the baseline font alignment.
  /// </summary>
  Auto = 4
}
