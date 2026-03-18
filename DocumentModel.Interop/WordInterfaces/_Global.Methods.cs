namespace DocumentModel.Interop;
public partial interface _Global : InteropObject
{
  /// <summary>
  /// Returns a SynonymInfo object with thesaurus information for the specified word or phrase.
  /// </summary>
  /// <param name="Word">The word or phrase to look up.</param>
  /// <param name="LanguageID">The language identifier.</param>
  public SynonymInfo get_SynonymInfo(string Word, object LanguageID);
  /// <summary>
  /// Returns a KeysBoundTo object that represents all key combinations assigned to the specified item.
  /// </summary>
  /// <param name="KeyCategory">The key category for the command.</param>
  /// <param name="Command">The command name.</param>
  /// <param name="CommandParameter">An optional command parameter.</param>
  public KeysBoundTo get_KeysBoundTo(WdKeyCategory KeyCategory, string Command, object CommandParameter);
  /// <summary>
  /// Returns a KeyBinding object that represents the specified key combination.
  /// </summary>
  /// <param name="KeyCode">The first key code.</param>
  /// <param name="KeyCode2">The second key code.</param>
  public KeyBinding get_FindKey(int KeyCode, object KeyCode2);
  /// <summary>
  /// Determines whether a variable that references an object is valid.
  /// </summary>
  /// <param name="Object">The object reference to validate.</param>
  public bool get_IsObjectValid(object Object);
  /// <summary>
  /// Repeats the most recent editing action one or more times.
  /// </summary>
  /// <param name="Times">The number of times to repeat the action.</param>
  public bool Repeat(object Times);
  /// <summary>
  /// Sends a command or series of commands through the specified dynamic data exchange (DDE) channel.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  /// <param name="Command">The command text to send.</param>
  public void DDEExecute(int Channel, string Command);
  /// <summary>
  /// Opens a dynamic data exchange (DDE) channel to another application and returns the channel number.
  /// </summary>
  /// <param name="App">The application name.</param>
  /// <param name="Topic">The topic name.</param>
  public int DDEInitiate(string App, string Topic);
  /// <summary>
  /// Uses an open dynamic data exchange (DDE) channel to send data to an application.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  /// <param name="Item">The item name.</param>
  /// <param name="Data">The data to send.</param>
  public void DDEPoke(int Channel, string Item, string Data);
  /// <summary>
  /// Uses an open dynamic data exchange (DDE) channel to request information and returns it as a string.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  /// <param name="Item">The item to request.</param>
  public string DDERequest(int Channel, string Item);
  /// <summary>
  /// Closes the specified dynamic data exchange (DDE) channel to another application.
  /// </summary>
  /// <param name="Channel">The DDE channel number.</param>
  public void DDETerminate(int Channel);
  /// <summary>
  /// Closes all dynamic data exchange (DDE) channels opened by Microsoft Word.
  /// </summary>
  public void DDETerminateAll();
  /// <summary>
  /// Returns a unique number for the specified key combination.
  /// </summary>
  /// <param name="Arg1">The first key.</param>
  /// <param name="Arg2">The second key.</param>
  /// <param name="Arg3">The third key.</param>
  /// <param name="Arg4">The fourth key.</param>
  public int BuildKeyCode(WdKey Arg1, object Arg2, object Arg3, object Arg4);
  /// <summary>
  /// Returns the key combination string for the specified keys.
  /// </summary>
  /// <param name="KeyCode">The first key code.</param>
  /// <param name="KeyCode2">The second key code.</param>
  public string KeyString(int KeyCode, object KeyCode2);
  /// <summary>
  /// Checks a string for spelling errors.
  /// </summary>
  /// <param name="Word">The text to check.</param>
  /// <param name="CustomDictionary">A custom dictionary.</param>
  /// <param name="IgnoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="MainDictionary">The main dictionary.</param>
  /// <param name="CustomDictionary2">An additional custom dictionary.</param>
  /// <param name="CustomDictionary3">An additional custom dictionary.</param>
  /// <param name="CustomDictionary4">An additional custom dictionary.</param>
  /// <param name="CustomDictionary5">An additional custom dictionary.</param>
  /// <param name="CustomDictionary6">An additional custom dictionary.</param>
  /// <param name="CustomDictionary7">An additional custom dictionary.</param>
  /// <param name="CustomDictionary8">An additional custom dictionary.</param>
  /// <param name="CustomDictionary9">An additional custom dictionary.</param>
  /// <param name="CustomDictionary10">An additional custom dictionary.</param>
  public bool CheckSpelling(string Word, object CustomDictionary, object IgnoreUppercase, object MainDictionary, object CustomDictionary2, object CustomDictionary3, object CustomDictionary4, object CustomDictionary5, object CustomDictionary6, object CustomDictionary7, object CustomDictionary8, object CustomDictionary9, object CustomDictionary10);
  /// <summary>
  /// Returns a SpellingSuggestions collection that represents suggested spelling replacements for a word.
  /// </summary>
  /// <param name="Word">The word to check.</param>
  /// <param name="CustomDictionary">A custom dictionary.</param>
  /// <param name="IgnoreUppercase">Whether to ignore uppercase words.</param>
  /// <param name="MainDictionary">The main dictionary.</param>
  /// <param name="SuggestionMode">The suggestion mode.</param>
  /// <param name="CustomDictionary2">An additional custom dictionary.</param>
  /// <param name="CustomDictionary3">An additional custom dictionary.</param>
  /// <param name="CustomDictionary4">An additional custom dictionary.</param>
  /// <param name="CustomDictionary5">An additional custom dictionary.</param>
  /// <param name="CustomDictionary6">An additional custom dictionary.</param>
  /// <param name="CustomDictionary7">An additional custom dictionary.</param>
  /// <param name="CustomDictionary8">An additional custom dictionary.</param>
  /// <param name="CustomDictionary9">An additional custom dictionary.</param>
  /// <param name="CustomDictionary10">An additional custom dictionary.</param>
  public SpellingSuggestions GetSpellingSuggestions(string Word, object CustomDictionary, object IgnoreUppercase, object MainDictionary, object SuggestionMode, object CustomDictionary2, object CustomDictionary3, object CustomDictionary4, object CustomDictionary5, object CustomDictionary6, object CustomDictionary7, object CustomDictionary8, object CustomDictionary9, object CustomDictionary10);
  /// <summary>
  /// Displays online Help information.
  /// </summary>
  /// <param name="HelpType">The type of Help to display.</param>
  public void Help(object HelpType);
  /// <summary>
  /// Opens a new window with the same document as the specified window.
  /// </summary>
  public Window NewWindow();
  /// <summary>
  /// Removes nonprinting and special Word characters from the specified string or changes them to spaces.
  /// </summary>
  /// <param name="String">The string to clean.</param>
  public string CleanString(string String);
  /// <summary>
  /// Sets the folder in which Microsoft Word searches for documents.
  /// </summary>
  /// <param name="Path">The folder path.</param>
  public void ChangeFileOpenDirectory(string Path);
  /// <summary>
  /// Converts a measurement from inches to points (1 inch = 72 points).
  /// </summary>
  /// <param name="Inches">The value in inches.</param>
  public float InchesToPoints(float Inches);
  /// <summary>
  /// Converts a measurement from centimeters to points (1 cm = 28.35 points).
  /// </summary>
  /// <param name="Centimeters">The value in centimeters.</param>
  public float CentimetersToPoints(float Centimeters);
  /// <summary>
  /// Converts a measurement from millimeters to points (1 mm = 2.85 points).
  /// </summary>
  /// <param name="Millimeters">The value in millimeters.</param>
  public float MillimetersToPoints(float Millimeters);
  /// <summary>
  /// Converts a measurement from picas to points (1 pica = 12 points).
  /// </summary>
  /// <param name="Picas">The value in picas.</param>
  public float PicasToPoints(float Picas);
  /// <summary>
  /// Converts a measurement from lines to points (1 line = 12 points).
  /// </summary>
  /// <param name="Lines">The value in lines.</param>
  public float LinesToPoints(float Lines);
  /// <summary>
  /// Converts a measurement from points to inches (1 inch = 72 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  public float PointsToInches(float Points);
  /// <summary>
  /// Converts a measurement from points to centimeters (1 centimeter = 28.35 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  public float PointsToCentimeters(float Points);
  /// <summary>
  /// Converts a measurement from points to millimeters (1 millimeter = 2.835 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  public float PointsToMillimeters(float Points);
  /// <summary>
  /// Converts a measurement from points to picas (1 pica = 12 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  public float PointsToPicas(float Points);
  /// <summary>
  /// Converts a measurement from points to lines (1 line = 12 points).
  /// </summary>
  /// <param name="Points">The value in points.</param>
  public float PointsToLines(float Points);
  /// <summary>
  /// Converts a measurement from points to pixels.
  /// </summary>
  /// <param name="Points">The value in points.</param>
  /// <param name="fVertical">Specifies whether conversion is for vertical measurements.</param>
  public float PointsToPixels(float Points, object fVertical);
  /// <summary>
  /// Converts a measurement from pixels to points.
  /// </summary>
  /// <param name="Pixels">The value in pixels.</param>
  /// <param name="fVertical">Specifies whether conversion is for vertical measurements.</param>
  public float PixelsToPoints(float Pixels, object fVertical);
}
