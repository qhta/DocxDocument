namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextWrappingValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextWrappingValues))]
public enum TextWrapping
{
  /// <summary>
  ///   Default Text Wrapping Around Frame.
  /// </summary>
  Auto,
  /// <summary>
  ///   No Text Wrapping Beside Frame.
  /// </summary>
  NotBeside,
  /// <summary>
  ///   Allow Text Wrapping Around Frame.
  /// </summary>
  Around,
  /// <summary>
  ///   Tight Text Wrapping Around Frame.
  /// </summary>
  Tight,
  /// <summary>
  ///   Through Text Wrapping Around Frame.
  /// </summary>
  Through,
  /// <summary>
  ///   No Text Wrapping Around Frame.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextWrappingValues.None))]
  None
}