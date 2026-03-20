
namespace DocumentModel.Interop.Core;

public delegate void _CustomXMLPartEvents_NodeAfterInsertEventHandler(CustomXMLNode NewNode, bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterDeleteEventHandler(
  CustomXMLNode OldNode,
  CustomXMLNode OldParentNode,
  CustomXMLNode OldNextSibling,
  bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterReplaceEventHandler(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);

/// <summary>
/// Events interface for CustomXMLPart object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpartevents_event?view=office-pia
/// </remarks>
public partial interface _CustomXMLPartEvents_Event
{
}
