namespace DocumentModel.Interop;

/// <summary>
/// Reserved for internal use.
/// </summary>
public partial interface ConnectorFormat : InteropObject
{
  /// <summary>
  /// The begin connected.
  /// </summary>
  //public Core.MsoTriState BeginConnected { get; }

  /// <summary>
  /// The begin connected shape.
  /// </summary>
  public Shape BeginConnectedShape { get; }

  /// <summary>
  /// The begin connection site.
  /// </summary>
  public int BeginConnectionSite { get; }

  /// <summary>
  /// The end connected.
  /// </summary>
  //public Core.MsoTriState EndConnected { get; }

  /// <summary>
  /// The end connected shape.
  /// </summary>
  public Shape EndConnectedShape { get; }

  /// <summary>
  /// The end connection site.
  /// </summary>
  public int EndConnectionSite { get; }

  /// <summary>
  /// The type.
  /// </summary>
  //public Core.MsoConnectorType Type { get; set; }
}
