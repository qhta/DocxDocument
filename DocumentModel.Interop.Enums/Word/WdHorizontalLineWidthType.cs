namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word interprets the width (length) of the specified horizontal line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontallinewidthtype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdHorizontalLineWidthType
{
  /// <summary>
  /// Specifies how Word interprets the width (length) of the specified horizontal line.
  /// </summary>
  FixedWidth = -2,
  /// <summary>
  /// Specifies how Word interprets the width (length) of the specified horizontal line.
  /// </summary>
  PercentWidth = -1
}
