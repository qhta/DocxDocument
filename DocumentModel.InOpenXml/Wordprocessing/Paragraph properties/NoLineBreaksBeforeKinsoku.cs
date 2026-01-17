namespace DocumentModel.Wordprocessing;

/// <summary>
///   Represents a custom set of characters that cannot begin a line in a WordprocessingML document.
///   This interface provides properties for specifying the language and the set of restricted characters, enabling advanced control over line breaking and kinsoku shori rules for East Asian and other scripts.
/// </summary>
public class NoLineBreaksBeforeKinsoku: ModelElement<DXW.NoLineBreaksBeforeKinsoku>
{
  /// <summary>
  ///   Language code for which the kinsoku rule applies, specifying the script or locale.
  /// </summary>
  public string? Language { get; set; }

  /// <summary>
  ///   Set of characters that cannot begin a line, specified as a string of restricted characters.
  /// </summary>
  public string? Val { get; set; }
}