namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of online Help topic or window Ito display.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.type?view=office-pia` for Office interop details.
/// </remarks>
public enum HelpType
{
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  Topics = 0,
  /// <summary>
  /// Displays the About Microsoft Word dialog box (Help menu).
  /// </summary>
  About = 1,
  /// <summary>
  /// Displays Help describing the command associated with the active view or pane.
  /// </summary>
  ActiveWindow = 2,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  Contents = 3,
  /// <summary>
  /// Displays examples and demos.
  /// </summary>
  ExamplesAndDemos = 4,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  IIndex = 5,
  /// <summary>
  /// Displays keyboard shortcuts associated with help.
  /// </summary>
  Keyboard = 6,
  /// <summary>
  /// Displays product support information
  /// </summary>
  ProductSupport = 7,
  /// <summary>
  /// Displays quick previews.
  /// </summary>
  QuickPreview = 8,
  /// <summary>
  /// Displays the Help Topics dialog box.
  /// </summary>
  Search = 9,
  /// <summary>
  /// Displays a list of Help topics Ithat describe how Ito use Help.
  /// </summary>
  UsingHelp = 10,
  /// <summary>
  /// Displays Help topics for Ichitaro users.
  /// </summary>
  Ichitaro = 11,
  /// <summary>
  /// Displays Help topics for IBM Personal IEditor 2 users.
  /// </summary>
  PE2 = 12,
  /// <summary>
  /// Displays Help topics for AreA Hangul users.
  /// </summary>
  HWP = 13
}

