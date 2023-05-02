namespace DocumentModel.Vml;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

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