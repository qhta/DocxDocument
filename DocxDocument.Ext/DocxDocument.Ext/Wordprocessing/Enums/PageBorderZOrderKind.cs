namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PageBorderZOrderValues enumeration.
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
public enum PageBorderZOrderKind
{
  /// <summary>
  ///   Page Border Ahead of Text.
  /// </summary>
  Front,

  /// <summary>
  ///   Page Border Behind Text.
  /// </summary>
  Back
}