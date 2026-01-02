namespace DocumentModel.Vml;

/// <summary>
///   OLE Object Representations
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OleDrawAspectKind
{
  /// <summary>
  ///   Snapshot.
  /// </summary>
  Content,
  /// <summary>
  ///   Icon.
  /// </summary>
  Icon
}