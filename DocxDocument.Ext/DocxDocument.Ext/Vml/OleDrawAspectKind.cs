namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   OLE Object Representations
/// </summary>
//[JsonConverter(typeof(StringEnumConverter))]
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