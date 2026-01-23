namespace DocumentModel.Vml;

/// <summary>
///   OLE Update Method Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum OleUpdateMode
{
  /// <summary>
  ///   Server Application Update.
  /// </summary>
  Always,
  /// <summary>
  ///   User Update.
  /// </summary>
  OnCall
}