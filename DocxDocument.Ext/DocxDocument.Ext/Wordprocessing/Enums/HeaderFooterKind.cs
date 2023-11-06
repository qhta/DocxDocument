namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Header/Footer kind enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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