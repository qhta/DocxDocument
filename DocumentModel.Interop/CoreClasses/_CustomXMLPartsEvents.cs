
namespace DocumentModel.Interop.Core;

/// <summary>
/// Events class for CustomXMLParts object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents?view=office-pia"/>
public partial class _CustomXMLPartsEvents
{


  #region methods

/// <summary>
  /// Occurs after a part is added in a CustomXMLParts object.
  /// </summary>
  /// <param name="NewPart">The `NewPart` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partafteradd?view=office-pia"/>
  public void PartAfterAdd(CustomXMLPart NewPart) { throw new NotImplementedException(); }
  /// <summary>
  /// Occurs before a part is deleted in a CustomXMLParts object.
  /// </summary>
  /// <param name="OldPart">The `OldPart` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partbeforedelete?view=office-pia"/>
  public void PartBeforeDelete(CustomXMLPart OldPart) { throw new NotImplementedException(); }
  /// <summary>
  /// Occurs after a part is loaded in a CustomXMLParts object.
  /// </summary>
  /// <param name="Part">The `Part` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents.partafterload?view=office-pia"/>
  public void PartAfterLoad(CustomXMLPart Part) { throw new NotImplementedException(); }

  #endregion methods
}

