namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the position of the caption label text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionposition?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCaptionPosition
{
  /// <summary>
  /// The caption label is added above.
  /// </summary>
  Above = 0,
  /// <summary>
  /// The caption label is added below.
  /// </summary>
  Below = 1
}
