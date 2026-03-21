namespace DocumentModel.Interop.Word;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat?view=word-pia"/>
public partial interface ConnectorFormat : InteropObject
{
  /// <summary>
  /// The begin connected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnected?view=word-pia"/>
  public Core.MsoTriState BeginConnected { get; }

  /// <summary>
  /// The begin connected shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnectedshape?view=word-pia"/>
  public Shape BeginConnectedShape { get; }

  /// <summary>
  /// The begin connection site.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.beginconnectionsite?view=word-pia"/>
  public int BeginConnectionSite { get; }

  /// <summary>
  /// The end connected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnected?view=word-pia"/>
  public Core.MsoTriState EndConnected { get; }

  /// <summary>
  /// The end connected shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnectedshape?view=word-pia"/>
  public Shape EndConnectedShape { get; }

  /// <summary>
  /// The end connection site.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.endconnectionsite?view=word-pia"/>
  public int EndConnectionSite { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.connectorformat.type?view=word-pia"/>
  public Core.MsoConnectorType Type { get; set; }
}
