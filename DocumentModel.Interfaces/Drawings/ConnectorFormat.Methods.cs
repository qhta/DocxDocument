
namespace DocumentModel.Drawings;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat?view=office-pia"/>
public partial interface IConnectorFormat : IModelObject
{
  /// <summary>
  /// Connects the beginning of the connector to a shape at the specified connection site.
  /// </summary>
  /// <param name="ConnectedShape">The `ConnectedShape` parameter.</param>
  /// <param name="ConnectionSite">The `ConnectionSite` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnect?view=office-pia"/>
  public void BeginConnect(IShape ConnectedShape, int ConnectionSite);
  /// <summary>
  /// Disconnects the beginning of the connector.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.begindisconnect?view=office-pia"/>
  public void BeginDisconnect();
  /// <summary>
  /// Connects the end of the connector to a shape at the specified connection site.
  /// </summary>
  /// <param name="ConnectedShape">The `ConnectedShape` parameter.</param>
  /// <param name="ConnectionSite">The `ConnectionSite` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnect?view=office-pia"/>
  public void EndConnect(IShape ConnectedShape, int ConnectionSite);
  /// <summary>
  /// Disconnects the end of the connector.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.enddisconnect?view=office-pia"/>
  public void EndDisconnect();
}

