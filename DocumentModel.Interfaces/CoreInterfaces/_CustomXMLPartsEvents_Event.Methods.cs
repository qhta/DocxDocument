
namespace DocumentModel.Interfaces;


/// <summary>
/// Events interface for CustomXMLParts object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event?view=office-pia"/>
public partial interface _CustomXMLPartsEvents_Event
{
  /// <summary>
  /// Occurs after a part is added in a CustomXMLParts object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event.partafteradd?view=office-pia"/>
  public event _CustomXMLPartsEvents_PartAfterAddEventHandler PartAfterAdd;
  /// <summary>
  /// Occurs before a part is deleted in a CustomXMLParts object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event.partbeforedelete?view=office-pia"/>
  public event _CustomXMLPartsEvents_PartBeforeDeleteEventHandler PartBeforeDelete;
  /// <summary>
  /// Occurs after a part is loaded in a CustomXMLParts object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event.partafterload?view=office-pia"/>
  public event _CustomXMLPartsEvents_PartAfterLoadEventHandler PartAfterLoad;
}

