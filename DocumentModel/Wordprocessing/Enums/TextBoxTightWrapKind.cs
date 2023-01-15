namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TextBoxTightWrapValues enumeration.
/// </summary>
public enum TextBoxTightWrapKind
{
  /// <summary>
  ///   Do Not Tight Wrap.
  /// </summary>
  None,

  /// <summary>
  ///   Tight Wrap All Lines.
  /// </summary>
  AllLines,

  /// <summary>
  ///   Tight Wrap First and Last Lines.
  /// </summary>
  FirstAndLastLine,

  /// <summary>
  ///   Tight Wrap First Line.
  /// </summary>
  FirstLineOnly,

  /// <summary>
  ///   Tight Wrap Last Line.
  /// </summary>
  LastLineOnly
}