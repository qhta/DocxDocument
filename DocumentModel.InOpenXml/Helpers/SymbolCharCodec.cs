namespace DocumentModel;

/// <summary>
/// This class provides methods for encoding and decoding symbol characters in WordprocessingML documents.
/// It loads the symbol character encoding table from an ENC file for a specified font
/// and provides methods to convert between symbol characters and their corresponding hexadecimal values.
/// </summary>
public static class SymbolCharCodec
{
  private static Dictionary<string, BiDiDictionary<char, HexChar>> _encodingTables = new Dictionary<string, BiDiDictionary<char, HexChar>>();
  private static readonly List<string> _unavailableEncodings = new List<string>();
  private static string _encAppFilePath => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "OpenXmlDocument.InOpenXml");
  private static string _encBinFilePath => Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly()!.Location)!, "Resources");


  /// <summary>
  /// This method loads the symbol character encoding table from an ENC file for the specified font
  /// and stores it in the _encodingTables dictionary for later use.
  /// If the ENC file for the specified font is not available, it adds the font name to the _unavailableEncodings list.
  /// </summary>
  /// <param name="fontName">The name of the font for which to load the ENC file.</param>
  /// <returns>True if the ENC file was successfully loaded; otherwise, false.</returns>
  public static bool LoadEncFile(string fontName)
  {
    var encAppFileName = Path.Combine(_encAppFilePath, fontName + ".enc");
    if (!File.Exists(encAppFileName))
    {
      var encBinFileName = Path.Combine(_encBinFilePath, fontName + ".enc");
      if (File.Exists(encBinFileName))
      {
        if (!Directory.Exists(_encAppFilePath))
        
          Directory.CreateDirectory(_encAppFilePath);
        File.Copy(encBinFileName, encAppFileName);
      }
      else
      {
        _unavailableEncodings.Add(fontName);
        return false;
      }
    }
    string[] lines = File.ReadAllLines(encAppFileName);
    var encDictionary = new BiDiDictionary<char, HexChar>();
    foreach (var line in lines) 
    {
      if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
        continue;
      var parts = line.Split([' ', '\t', ',', ';'], StringSplitOptions.RemoveEmptyEntries);
      if (parts.Length != 2)
        continue;
      char symbolChar = HexChar.Parse(parts[0]).ToChar();
      HexChar hexChar = HexChar.Parse(parts[1]);
      encDictionary.Add(symbolChar, hexChar);
    }

    _encodingTables[fontName] = encDictionary;
    return true;
  }

  /// <summary>
  /// This method retrieves the hexadecimal value corresponding to a symbol character for a specified font.
  /// </summary>
  /// <param name="fontName">The name of the font.</param>
  /// <param name="symbolChar">The symbol character.</param>
  /// <returns>The corresponding hexadecimal value, or null if not found.</returns>
  public static HexChar? GetHexChar(string fontName, char symbolChar)
  {
    if (!_encodingTables.ContainsKey(fontName))
    {
      if (_unavailableEncodings.Contains(fontName))
        return null;
      if (!LoadEncFile(fontName))
        return null;
    }
    var encDictionary = _encodingTables[fontName];
    if (encDictionary.TryGetValue(symbolChar, out HexChar hexChar))
      return hexChar;
    return null;
  }
}