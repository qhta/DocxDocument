
namespace DocumentModel.Application;


/// <summary>
/// Events interface for CustomXMLPart object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event?view=office-pia"/>
public partial interface _CustomXMLPartEvents_Event
{
  /// <summary>
  /// Occurs after a node is inserted in a CustomXMLPart object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event.nodeafterinsert?view=office-pia"/>
  public event _CustomXMLPartEvents_NodeAfterInsertEventHandler NodeAfterInsert;
  /// <summary>
  /// Occurs after a node is deleted in a CustomXMLPart object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event.nodeafterdelete?view=office-pia"/>
  public event _CustomXMLPartEvents_NodeAfterDeleteEventHandler NodeAfterDelete;
  /// <summary>
  /// Occurs just after a node is replaced in a CustomXMLPart object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event.nodeafterreplace?view=office-pia"/>
  public event _CustomXMLPartEvents_NodeAfterReplaceEventHandler NodeAfterReplace;
}

