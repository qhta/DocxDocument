namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the TextBoxTightWrapValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
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