
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ICustomXMLPartsEvents` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICustomXMLPartsEvents
{
  /// <summary>
  /// Invokes `PartAfterAdd`.
  /// </summary>
  /// <param name="NewPart">The `NewPart` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafteradd?view=office-pia
  /// </remarks>
  public void PartAfterAdd(CustomXMLPart NewPart);
  /// <summary>
  /// Invokes `PartBeforeDelete`.
  /// </summary>
  /// <param name="OldPart">The `OldPart` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partbeforedelete?view=office-pia
  /// </remarks>
  public void PartBeforeDelete(CustomXMLPart OldPart);
  /// <summary>
  /// Invokes `PartAfterLoad`.
  /// </summary>
  /// <param name="Part">The `Part` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafterload?view=office-pia
  /// </remarks>
  public void PartAfterLoad(CustomXMLPart Part);
}
