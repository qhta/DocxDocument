namespace DocumentModel.Vml;

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