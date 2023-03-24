namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Font Collection Index
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontCollectionIndexKind
{
  /// <summary>
  ///   Major Font.
  /// </summary>
  Major,

  /// <summary>
  ///   Minor Font.
  /// </summary>
  Minor,

  /// <summary>
  ///   None.
  /// </summary>
  None
}