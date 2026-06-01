
namespace DocumentModel.Interop.Core;


/// <summary>
/// Events class for CustomXMLPart object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event?view=office-pia"/>
public partial class _CustomXMLPartEvents_Event
{
  /// <summary>
  /// Occurs after a node is inserted in a CustomXMLPart object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event.nodeafterinsert?view=office-pia"/>
  public event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
  /// <summary>
  /// Occurs after a node is deleted in a CustomXMLPart object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event.nodeafterdelete?view=office-pia"/>
  public event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
  /// <summary>
  /// Occurs just after a node is replaced in a CustomXMLPart object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event.nodeafterreplace?view=office-pia"/>
  public event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
}

