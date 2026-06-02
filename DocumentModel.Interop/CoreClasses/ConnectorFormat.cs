
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat?view=office-pia"/>
public partial class ConnectorFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `BeginConnected` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnected?view=office-pia"/>
  public TriState BeginConnected { get; }
  /// <summary>
  /// Gets the `BeginConnectedShape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnectedshape?view=office-pia"/>
  public Shape BeginConnectedShape { get; }
  /// <summary>
  /// Gets the `BeginConnectionSite` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnectionsite?view=office-pia"/>
  public int BeginConnectionSite { get; }
  /// <summary>
  /// Gets the `EndConnected` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnected?view=office-pia"/>
  public TriState EndConnected { get; }
  /// <summary>
  /// Gets the `EndConnectedShape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnectedshape?view=office-pia"/>
  public Shape EndConnectedShape { get; }
  /// <summary>
  /// Gets the `EndConnectionSite` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnectionsite?view=office-pia"/>
  public int EndConnectionSite { get; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.type?view=office-pia"/>
  public ConnectorType Type { get; set; }


  #region methods

/// <summary>
  /// Connects the beginning of the connector to a shape at the specified connection site.
  /// </summary>
  /// <param name="ConnectedShape">The `ConnectedShape` parameter.</param>
  /// <param name="ConnectionSite">The `ConnectionSite` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnect?view=office-pia"/>
  public void BeginConnect(Shape ConnectedShape, int ConnectionSite) { throw new NotImplementedException(); }
  /// <summary>
  /// Disconnects the beginning of the connector.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.begindisconnect?view=office-pia"/>
  public void BeginDisconnect() { throw new NotImplementedException(); }
  /// <summary>
  /// Connects the end of the connector to a shape at the specified connection site.
  /// </summary>
  /// <param name="ConnectedShape">The `ConnectedShape` parameter.</param>
  /// <param name="ConnectionSite">The `ConnectionSite` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnect?view=office-pia"/>
  public void EndConnect(Shape ConnectedShape, int ConnectionSite) { throw new NotImplementedException(); }
  /// <summary>
  /// Disconnects the end of the connector.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.enddisconnect?view=office-pia"/>
  public void EndDisconnect() { throw new NotImplementedException(); }

  #endregion methods
}

