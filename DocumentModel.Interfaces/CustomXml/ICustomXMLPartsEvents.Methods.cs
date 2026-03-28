
namespace DocumentModel.CustomXml;

/// <summary>
/// Events interface for `CustomXMLParts` object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents?view=office-pia"/>
public partial interface ICustomXMLPartsEvents: InteropObject
{
  /// <summary>
  /// Raised after a custom XML part is added.
  /// </summary>
  /// <param name="NewPart">The `NewPart` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafteradd?view=office-pia"/>
  public void PartAfterAdd(CustomXMLPart NewPart);
  /// <summary>
  /// Raised before a custom XML part is deleted.
  /// </summary>
  /// <param name="OldPart">The `OldPart` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partbeforedelete?view=office-pia"/>
  public void PartBeforeDelete(CustomXMLPart OldPart);
  /// <summary>
  /// Raised after a custom XML part is loaded.
  /// </summary>
  /// <param name="Part">The `Part` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafterload?view=office-pia"/>
  public void PartAfterLoad(CustomXMLPart Part);
}

