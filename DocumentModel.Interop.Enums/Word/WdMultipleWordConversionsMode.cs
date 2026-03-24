namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the direction for conversion between Hangul and Hanja.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdmultiplewordconversionsmode?view=office-pia` for Office interop details.
/// </remarks>
public enum WdMultipleWordConversionsMode
{
  /// <summary>
  /// Hangul to Hanja.
  /// </summary>
  gulToHanja = 0,
  /// <summary>
  /// Hanja to Hangul.
  /// </summary>
  jaToHangul = 1
}
