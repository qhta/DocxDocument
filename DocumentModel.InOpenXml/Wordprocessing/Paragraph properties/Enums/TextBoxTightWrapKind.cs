namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextBoxTightWrapValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.TextBoxTightWrapValues))]
public enum TextBoxTightWrapKind
{
  /// <summary>
  ///   Do Not Tight Wrap.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxTightWrapValues.None))]
  None,
  /// <summary>
  ///   Tight Wrap All Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxTightWrapValues.AllLines))]
  AllLines,
  /// <summary>
  ///   Tight Wrap First and Last Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxTightWrapValues.FirstAndLastLine))]
  FirstAndLastLine,
  /// <summary>
  ///   Tight Wrap First Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxTightWrapValues.FirstLineOnly))]
  FirstLineOnly,
  /// <summary>
  ///   Tight Wrap Last Line.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.TextBoxTightWrapValues.LastLineOnly))]
  LastLineOnly
}