namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the margin where revision balloons should be displayed.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrevisionsballoonmargin?view=office-pia` for Office interop details.
/// </remarks>
public enum WdRevisionsBalloonMargin
{
  /// <summary>
  /// Left margin.
  /// </summary>
  LeftMargin = 0,
  /// <summary>
  /// Right margin. default.
  /// </summary>
  RightMargin = 1
}
