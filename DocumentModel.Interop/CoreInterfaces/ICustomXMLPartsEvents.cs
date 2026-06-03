
namespace DocumentModel.Interop.Core;

/// <summary>
/// Events interface for `CustomXMLParts` object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents?view=office-pia"/>
public interface ICustomXMLPartsEvents
{


  #region methods

/// <summary>
  /// Raised after a custom XML part is added.
  /// </summary>
  /// <param name="newPart">The `NewPart` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafteradd?view=office-pia"/>
  public void PartAfterAdd(ICustomXMLPart newPart);
  /// <summary>
  /// Raised before a custom XML part is deleted.
  /// </summary>
  /// <param name="oldPart">The `OldPart` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partbeforedelete?view=office-pia"/>
  public void PartBeforeDelete(ICustomXMLPart oldPart);
  /// <summary>
  /// Raised after a custom XML part is loaded.
  /// </summary>
  /// <param name="part">The `Part` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icustomxmlpartsevents.partafterload?view=office-pia"/>
  public void PartAfterLoad(ICustomXMLPart part);

  #endregion methods
}

