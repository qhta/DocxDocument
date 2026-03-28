
namespace DocumentModel.CustomXml;

/// <summary>
/// Events interface for CustomXMLParts object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents?view=office-pia"/>
public partial interface _CustomXMLPartsEvents
{
  /// <summary>
  /// Occurs after a part is added in a CustomXMLParts object.
  /// </summary>
  /// <param name="NewPart">The `NewPart` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partafteradd?view=office-pia"/>
  public void PartAfterAdd(CustomXMLPart NewPart);
  /// <summary>
  /// Occurs before a part is deleted in a CustomXMLParts object.
  /// </summary>
  /// <param name="OldPart">The `OldPart` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partbeforedelete?view=office-pia"/>
  public void PartBeforeDelete(CustomXMLPart OldPart);
  /// <summary>
  /// Occurs after a part is loaded in a CustomXMLParts object.
  /// </summary>
  /// <param name="Part">The `Part` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partafterload?view=office-pia"/>
  public void PartAfterLoad(CustomXMLPart Part);
}

