
namespace DocumentModel.Interop.Core;

/// <summary>
/// Events interface for `CustomXMLParts` object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents?view=office-pia
/// </remarks>
public partial interface ICustomXMLPartsEvents
{
  /// <summary>
  /// Raised after a custom XML part is added.
  /// </summary>
  /// <param name="NewPart">The `NewPart` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafteradd?view=office-pia
  /// </remarks>
  public void PartAfterAdd(CustomXMLPart NewPart);
  /// <summary>
  /// Raised before a custom XML part is deleted.
  /// </summary>
  /// <param name="OldPart">The `OldPart` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partbeforedelete?view=office-pia
  /// </remarks>
  public void PartBeforeDelete(CustomXMLPart OldPart);
  /// <summary>
  /// Raised after a custom XML part is loaded.
  /// </summary>
  /// <param name="Part">The `Part` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafterload?view=office-pia
  /// </remarks>
  public void PartAfterLoad(CustomXMLPart Part);
}
