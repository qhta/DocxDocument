namespace DocumentModel.Drawings;

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