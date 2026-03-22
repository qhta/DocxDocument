namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of symbol to use as an enclosure.
/// </summary>
public enum WdEnclosureType
{
  /// <summary>
  /// A circle.
  /// </summary>
  wdEnclosureCircle = unchecked((int)0),
  /// <summary>
  /// A square.
  /// </summary>
  wdEnclosureSquare = unchecked((int)1),
  /// <summary>
  /// A triangle.
  /// </summary>
  wdEnclosureTriangle = unchecked((int)2),
  /// <summary>
  /// A diamond.
  /// </summary>
  wdEnclosureDiamond = unchecked((int)3)
}
