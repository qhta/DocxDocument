namespace DocumentModel.Interop.Core;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
public delegate void MsoEnvelopeVBEvents_EnvelopeShowEventHandler();
public delegate void MsoEnvelopeVBEvents_EnvelopeHideEventHandler();
public delegate void _CommandBarComboBoxEvents_ChangeEventHandler(CommandBarComboBox Ctrl);
public delegate void _CommandBarsEvents_OnUpdateEventHandler();
public delegate void _CommandBarButtonEvents_ClickEventHandler(CommandBarButton Ctrl, ref bool CancelDefault);
public delegate void _CustomTaskPaneEvents_VisibleStateChangeEventHandler(CustomTaskPane CustomTaskPaneInst);
public delegate void _CustomTaskPaneEvents_DockPositionStateChangeEventHandler(CustomTaskPane CustomTaskPaneInst);
public delegate void _CustomXMLPartEvents_NodeAfterInsertEventHandler(CustomXMLNode NewNode, bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterDeleteEventHandler(CustomXMLNode OldNode, CustomXMLNode OldParentNode, CustomXMLNode OldNextSibling, bool InUndoRedo);
public delegate void _CustomXMLPartEvents_NodeAfterReplaceEventHandler(CustomXMLNode OldNode, CustomXMLNode NewNode, bool InUndoRedo);
public delegate void _CustomXMLPartsEvents_PartAfterAddEventHandler(CustomXMLPart NewPart);
public delegate void _CustomXMLPartsEvents_PartBeforeDeleteEventHandler(CustomXMLPart OldPart);
public delegate void _CustomXMLPartsEvents_PartAfterLoadEventHandler(CustomXMLPart Part);




