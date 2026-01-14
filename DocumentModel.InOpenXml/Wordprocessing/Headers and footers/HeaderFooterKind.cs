namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Header/Footer kind enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HeaderFooterKind
{
  /// <summary>
  ///   Even Numbered Pages Only.
  /// </summary>
  Even,
  /// <summary>
  ///   Default Header or Footer.
  /// </summary>
  Default,
  /// <summary>
  ///   First Page Only.
  /// </summary>
  First
}