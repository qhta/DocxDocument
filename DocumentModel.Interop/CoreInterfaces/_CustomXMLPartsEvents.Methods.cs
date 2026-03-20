
namespace DocumentModel.Interop.Core;

/// <summary>
/// Events interface for CustomXMLParts object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents?view=office-pia
/// </remarks>
public partial interface _CustomXMLPartsEvents
{
  /// <summary>
  /// Occurs after a part is added in a CustomXMLParts object.
  /// </summary>
  /// <param name="NewPart">The `NewPart` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partafteradd?view=office-pia
  /// </remarks>
  public void PartAfterAdd(CustomXMLPart NewPart);
  /// <summary>
  /// Occurs before a part is deleted in a CustomXMLParts object.
  /// </summary>
  /// <param name="OldPart">The `OldPart` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partbeforedelete?view=office-pia
  /// </remarks>
  public void PartBeforeDelete(CustomXMLPart OldPart);
  /// <summary>
  /// Occurs after a part is loaded in a CustomXMLParts object.
  /// </summary>
  /// <param name="Part">The `Part` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partafterload?view=office-pia
  /// </remarks>
  public void PartAfterLoad(CustomXMLPart Part);
}
