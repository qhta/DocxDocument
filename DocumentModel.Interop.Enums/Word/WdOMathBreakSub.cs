namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdomathbreaksub?view=office-pia` for Office interop details.
/// </remarks>
public enum WdOMathBreakSub
{
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  MinusMinus = 0,
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  PlusMinus = 1,
  /// <summary>
  /// Specifies how Microsoft Office Word handles a subtraction operator that falls before a line break.
  /// </summary>
  MinusPlus = 2
}
