namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of section break for the specified item.
/// </summary>
public enum WdSectionStart
{
  /// <summary>
  /// Continuous section break.
  /// </summary>
  Continuous = unchecked((int)0),
  /// <summary>
  /// New column section break.
  /// </summary>
  NewColumn = unchecked((int)1),
  /// <summary>
  /// New page section break.
  /// </summary>
  NewPage = unchecked((int)2),
  /// <summary>
  /// Even pages section break.
  /// </summary>
  EvenPage = unchecked((int)3),
  /// <summary>
  /// Odd pages section break.
  /// </summary>
  OddPage = unchecked((int)4)
}
