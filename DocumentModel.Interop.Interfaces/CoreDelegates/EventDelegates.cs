namespace DocumentModel.Interop.Core;	
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public delegate void MsoEnvelopeVBEvents_EnvelopeShowEventHandler();
public delegate void MsoEnvelopeVBEvents_EnvelopeHideEventHandler();
public delegate void _CommandBarComboBoxEvents_ChangeEventHandler(ICommandBarComboBox Ctrl);
public delegate void _CommandBarsEvents_OnUpdateEventHandler();
public delegate void _CommandBarButtonEvents_ClickEventHandler(ICommandBarButton Ctrl, ref bool CancelDefault);
public delegate void _CustomTaskPaneEvents_VisibleStateChangeEventHandler(ICustomTaskPane CustomTaskPaneInst);
public delegate void _CustomTaskPaneEvents_DockPositionStateChangeEventHandler(ICustomTaskPane CustomTaskPaneInst);
public delegate void _CustomXMLPartEvents_NodeAfterInsertEventHandler(ICustomXMLNode NewNode, bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterDeleteEventHandler(ICustomXMLNode OldNode, ICustomXMLNode OldParentNode, ICustomXMLNode OldNextSibling, bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterReplaceEventHandler(ICustomXMLNode OldNode, ICustomXMLNode NewNode, bool InUndoRedo);
public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler(ICustomXMLPart NewPart);
public delegate void _CustomXMLPartsEvents_PartBeforeDeleteEventHandler(ICustomXMLPart OldPart);
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler(ICustomXMLPart Part);	
	

