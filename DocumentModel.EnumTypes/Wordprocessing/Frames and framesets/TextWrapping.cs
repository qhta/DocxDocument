namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the TextWrappingValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextWrappingValues))]
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
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextWrappingValues.None))]
  None
}