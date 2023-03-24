namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   OLE Connection Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OleKind
{
  /// <summary>
  ///   Embedded Object.
  /// </summary>
  Embed,

  /// <summary>
  ///   Linked Object.
  /// </summary>
  Link
}