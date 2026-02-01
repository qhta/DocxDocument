namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocGridValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DocGridValues))]
public enum DocGridKind
{
  /// <summary>
  ///   No Document Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocGridValues.Default))]
  Default,
  /// <summary>
  ///   Line Grid Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocGridValues.Lines))]
  Lines,
  /// <summary>
  ///   Line and Character Grid.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocGridValues.LinesAndChars))]
  LinesAndChars,
  /// <summary>
  ///   Character Grid Only.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocGridValues.SnapToChars))]
  SnapToChars
}