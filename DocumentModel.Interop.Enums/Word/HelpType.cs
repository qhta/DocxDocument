namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of online Help topic or window to display.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhelptype?view=office-pia` for Office interop details.
/// </remarks>
public enum HelpType
{
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  wdHelp = 0,
  /// <summary>
  /// Displays the About Microsoft Word dialog box (Help menu).
  /// </summary>
  wdHelpAbout = 1,
  /// <summary>
  /// Displays Help describing the command associated with the active view or pane.
  /// </summary>
  wdHelpActiveWindow = 2,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  wdHelpContents = 3,
  /// <summary>
  /// Displays examples and demos.
  /// </summary>
  wdHelpExamplesAndDemos = 4,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  wdHelpIndex = 5,
  /// <summary>
  /// Displays keyboard shortcuts associated with help.
  /// </summary>
  wdHelpKeyboard = 6,
  /// <summary>
  /// Displays product support information
  /// </summary>
  wdHelpPSSHelp = 7,
  /// <summary>
  /// Displays quick previews.
  /// </summary>
  wdHelpQuickPreview = 8,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  wdHelpSearch = 9,
  /// <summary>
  /// Displays a list of Help topics that describe how to use Help.
  /// </summary>
  wdHelpUsingHelp = 10,
  /// <summary>
  /// Displays Help topics for Ichitaro users.
  /// </summary>
  wdHelpIchitaro = 11,
  /// <summary>
  /// Displays Help topics for IBM Personal Editor 2 users.
  /// </summary>
  wdHelpPE2 = 12,
  /// <summary>
  /// Displays Help topics for AreA Hangul users.
  /// </summary>
  wdHelpHWP = 13
}
