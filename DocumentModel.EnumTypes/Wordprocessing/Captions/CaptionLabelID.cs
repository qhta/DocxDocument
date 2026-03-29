namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type for a caption label.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdcaptionlabelid?view=office-pia` for Office interop details.
/// </remarks>
public enum CaptionLabelID
{
  /// <summary>
  /// Equation.
  /// </summary>
  Equation = -3,
  /// <summary>
  /// Table.
  /// </summary>
  Table = -2,
  /// <summary>
  /// Figure.
  /// </summary>
  Figure = -1
}
