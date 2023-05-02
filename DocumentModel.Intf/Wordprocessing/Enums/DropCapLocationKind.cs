namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DropCapLocationValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DropCapLocationKind
{
  /// <summary>
  ///   Not Drop Cap.
  /// </summary>
  None,

  /// <summary>
  ///   Drop Cap Inside Margin.
  /// </summary>
  Drop,

  /// <summary>
  ///   Drop Cap Outside Margin.
  /// </summary>
  Margin
}