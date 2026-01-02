namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the AbsolutePositionTabPositioningBaseValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AbsolutePositionTabPositioningBaseKind
{
  /// <summary>
  ///   Relative To Text Margins.
  /// </summary>
  Margin,
  /// <summary>
  ///   Relative To Indents.
  /// </summary>
  Indent
}