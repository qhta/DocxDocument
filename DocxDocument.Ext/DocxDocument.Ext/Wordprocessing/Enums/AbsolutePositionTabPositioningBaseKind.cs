namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the AbsolutePositionTabPositioningBaseValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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