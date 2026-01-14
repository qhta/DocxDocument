namespace DocumentModel.Drawings;

/// <summary>
///   Specifies the color type for a hyperlink in a drawing object.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HyperlinkColorEnum
{
  /// <summary>
  ///   Hyperlink color. Indicates that the standard hyperlink color is applied.
  /// </summary>
  HLink,

  /// <summary>
  ///   Text color. Indicates that the hyperlink uses the surrounding text color.
  /// </summary>
  Tx
}