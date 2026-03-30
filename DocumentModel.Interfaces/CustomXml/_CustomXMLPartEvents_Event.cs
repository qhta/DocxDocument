
namespace DocumentModel.CustomXml;

public delegate void _CustomXMLPartEvents_NodeAfterInsertEventHandler(ICustomXMLNode NewNode, bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterDeleteEventHandler(
  ICustomXMLNode OldNode,
  ICustomXMLNode OldParentNode,
  ICustomXMLNode OldNextSibling,
  bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterReplaceEventHandler(ICustomXMLNode OldNode, ICustomXMLNode NewNode, bool InUndoRedo);

/// <summary>
/// Events interface for CustomXMLPart object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event?view=office-pia"/>
public partial interface I_CustomXMLPartEvents_Event
{
}

