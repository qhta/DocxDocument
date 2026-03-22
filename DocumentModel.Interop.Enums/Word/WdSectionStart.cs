namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of section break for the specified item.
/// </summary>
public enum WdSectionStart
{
  /// <summary>
  /// Continuous section break.
  /// </summary>
  wdSectionContinuous = unchecked((int)0),
  /// <summary>
  /// New column section break.
  /// </summary>
  wdSectionNewColumn = unchecked((int)1),
  /// <summary>
  /// New page section break.
  /// </summary>
  wdSectionNewPage = unchecked((int)2),
  /// <summary>
  /// Even pages section break.
  /// </summary>
  wdSectionEvenPage = unchecked((int)3),
  /// <summary>
  /// Odd pages section break.
  /// </summary>
  wdSectionOddPage = unchecked((int)4)
}
