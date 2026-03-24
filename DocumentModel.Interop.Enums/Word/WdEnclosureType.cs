namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of symbol to use as an enclosure.
/// </summary>
public enum WdEnclosureType
{
  /// <summary>
  /// A circle.
  /// </summary>
  Circle = unchecked((int)0),
  /// <summary>
  /// A square.
  /// </summary>
  Square = unchecked((int)1),
  /// <summary>
  /// A triangle.
  /// </summary>
  Triangle = unchecked((int)2),
  /// <summary>
  /// A diamond.
  /// </summary>
  Diamond = unchecked((int)3)
}
