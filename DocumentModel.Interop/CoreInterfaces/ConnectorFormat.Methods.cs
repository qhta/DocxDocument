
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat?view=office-pia
/// </remarks>
public partial interface ConnectorFormat
{
  /// <summary>
  /// Connects the beginning of the connector to a shape at the specified connection site.
  /// </summary>
  /// <param name="ConnectedShape">The `ConnectedShape` parameter.</param>
  /// <param name="ConnectionSite">The `ConnectionSite` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.beginconnect?view=office-pia
  /// </remarks>
  public void BeginConnect(Shape ConnectedShape, int ConnectionSite);
  /// <summary>
  /// Disconnects the beginning of the connector.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.begindisconnect?view=office-pia
  /// </remarks>
  public void BeginDisconnect();
  /// <summary>
  /// Connects the end of the connector to a shape at the specified connection site.
  /// </summary>
  /// <param name="ConnectedShape">The `ConnectedShape` parameter.</param>
  /// <param name="ConnectionSite">The `ConnectionSite` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.endconnect?view=office-pia
  /// </remarks>
  public void EndConnect(Shape ConnectedShape, int ConnectionSite);
  /// <summary>
  /// Disconnects the end of the connector.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.connectorformat.enddisconnect?view=office-pia
  /// </remarks>
  public void EndDisconnect();
}
