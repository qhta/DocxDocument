namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of online Help topic or window to display.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhelptype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdHelpType")]
public enum HelpType
{
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [InteropEnumValue("wdHelp")]
  wdHelp = 0,
  /// <summary>
  /// Displays the About Microsoft Word dialog box (Help menu).
  /// </summary>
  [InteropEnumValue("wdHelpAbout")]
  wdHelpAbout = 1,
  /// <summary>
  /// Displays Help describing the command associated with the active view or pane.
  /// </summary>
  [InteropEnumValue("wdHelpActiveWindow")]
  wdHelpActiveWindow = 2,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [InteropEnumValue("wdHelpContents")]
  wdHelpContents = 3,
  /// <summary>
  /// Displays examples and demos.
  /// </summary>
  [InteropEnumValue("wdHelpExamplesAndDemos")]
  wdHelpExamplesAndDemos = 4,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [InteropEnumValue("wdHelpIndex")]
  wdHelpIndex = 5,
  /// <summary>
  /// Displays keyboard shortcuts associated with help.
  /// </summary>
  [InteropEnumValue("wdHelpKeyboard")]
  wdHelpKeyboard = 6,
  /// <summary>
  /// Displays product support information
  /// </summary>
  [InteropEnumValue("wdHelpPSSHelp")]
  wdHelpPSSHelp = 7,
  /// <summary>
  /// Displays quick previews.
  /// </summary>
  [InteropEnumValue("wdHelpQuickPreview")]
  wdHelpQuickPreview = 8,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  [InteropEnumValue("wdHelpSearch")]
  wdHelpSearch = 9,
  /// <summary>
  /// Displays a list of Help topics that describe how to use Help.
  /// </summary>
  [InteropEnumValue("wdHelpUsingHelp")]
  wdHelpUsingHelp = 10,
  /// <summary>
  /// Displays Help topics for Ichitaro users.
  /// </summary>
  [InteropEnumValue("wdHelpIchitaro")]
  wdHelpIchitaro = 11,
  /// <summary>
  /// Displays Help topics for IBM Personal Editor 2 users.
  /// </summary>
  [InteropEnumValue("wdHelpPE2")]
  wdHelpPE2 = 12,
  /// <summary>
  /// Displays Help topics for AreA Hangul users.
  /// </summary>
  [InteropEnumValue("wdHelpHWP")]
  wdHelpHWP = 13
}
