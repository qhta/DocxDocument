namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of online Help topic or window to display.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhelptype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdHelpType))]
public enum HelpType
{
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelp))]
  wdHelp = 0,
  /// <summary>
  /// Displays the About Microsoft Word dialog box (Help menu).
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpAbout))]
  wdHelpAbout = 1,
  /// <summary>
  /// Displays Help describing the command associated with the active view or pane.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpActiveWindow))]
  wdHelpActiveWindow = 2,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpContents))]
  wdHelpContents = 3,
  /// <summary>
  /// Displays examples and demos.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpExamplesAndDemos))]
  wdHelpExamplesAndDemos = 4,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpIndex))]
  wdHelpIndex = 5,
  /// <summary>
  /// Displays keyboard shortcuts associated with help.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpKeyboard))]
  wdHelpKeyboard = 6,
  /// <summary>
  /// Displays product support information
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpPSSHelp))]
  wdHelpPSSHelp = 7,
  /// <summary>
  /// Displays quick previews.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpQuickPreview))]
  wdHelpQuickPreview = 8,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpSearch))]
  wdHelpSearch = 9,
  /// <summary>
  /// Displays a list of Help topics that describe how to use Help.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpUsingHelp))]
  wdHelpUsingHelp = 10,
  /// <summary>
  /// Displays Help topics for Ichitaro users.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpIchitaro))]
  wdHelpIchitaro = 11,
  /// <summary>
  /// Displays Help topics for IBM Personal Editor 2 users.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpPE2))]
  wdHelpPE2 = 12,
  /// <summary>
  /// Displays Help topics for AreA Hangul users.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHelpType.wdHelpHWP))]
  wdHelpHWP = 13
}
