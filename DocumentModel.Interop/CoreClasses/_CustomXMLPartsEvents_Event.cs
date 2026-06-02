
namespace DocumentModel.Interop.Core;

/// <summary>
/// Events class for CustomXMLParts object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event?view=office-pia"/>
public partial class _CustomXMLPartsEvents_Event
{


  #region methods

/// <summary>
  /// Occurs after a part is added in a CustomXMLParts object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event.partafteradd?view=office-pia"/>
  public event _CustomXMLPartsEvents_PartAfterAddEventHandler PartAfterAdd { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
  /// <summary>
  /// Occurs before a part is deleted in a CustomXMLParts object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event.partbeforedelete?view=office-pia"/>
  public event _CustomXMLPartsEvents_PartBeforeDeleteEventHandler PartBeforeDelete { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
  /// <summary>
  /// Occurs after a part is loaded in a CustomXMLParts object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartsevents_event.partafterload?view=office-pia"/>
  public event _CustomXMLPartsEvents_PartAfterLoadEventHandler PartAfterLoad { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }

  #endregion methods
}

