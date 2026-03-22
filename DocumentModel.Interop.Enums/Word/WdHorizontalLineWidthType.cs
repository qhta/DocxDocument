namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word interprets the width (length) of the specified horizontal line.
/// </summary>
public enum WdHorizontalLineWidthType
{
  /// <summary>
  /// Specifies how Word interprets the width (length) of the specified horizontal line.
  /// </summary>
  wdHorizontalLineFixedWidth = unchecked((int)-2),
  /// <summary>
  /// Specifies how Word interprets the width (length) of the specified horizontal line.
  /// </summary>
  wdHorizontalLinePercentWidth = unchecked((int)-1)
}
