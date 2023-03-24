namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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