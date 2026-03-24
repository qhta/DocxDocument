namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type for a caption label.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionlabelid?view=office-pia` for Office interop details.
/// </remarks>
public enum WdCaptionLabelID
{
  /// <summary>
  /// Specifies the type for a caption label.
  /// </summary>
  Equation = -3,
  /// <summary>
  /// Specifies the type for a caption label.
  /// </summary>
  Table = -2,
  /// <summary>
  /// Specifies the type for a caption label.
  /// </summary>
  Figure = -1
}
