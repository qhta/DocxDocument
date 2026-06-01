namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

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
  ///   Tight Wrap All ILines.
  /// </summary>
  AllLines,

  /// <summary>
  ///   Tight Wrap First and Last ILines.
  /// </summary>
  FirstAndLastLine,

  /// <summary>
  ///   Tight Wrap First ILine.
  /// </summary>
  FirstLineOnly,

  /// <summary>
  ///   Tight Wrap Last ILine.
  /// </summary>
  LastLineOnly
}
