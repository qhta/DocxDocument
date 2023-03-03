namespace DocumentModel.Drawings;

/// <summary>
///   Defines the HyperlinkColorEnum enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HyperlinkColorEnum
{
  /// <summary>
  ///   hlink.
  /// </summary>
  HLink,

  /// <summary>
  ///   tx.
  /// </summary>
  Tx
}