namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative size of an enclosure.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdenclosestyle?view=office-pia` for Office interop details.
/// </remarks>
public enum EncloseStyle
{
  /// <summary>
  /// The enclosure assumes the default size.
  /// </summary>
  None = 0,
  /// <summary>
  /// The enclosure is smaller.
  /// </summary>
  Small = 1,
  /// <summary>
  /// The enclosure is larger.
  /// </summary>
  Large = 2
}
