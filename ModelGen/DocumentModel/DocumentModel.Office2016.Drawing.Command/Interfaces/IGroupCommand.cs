namespace DocumentModel.Office2016.Drawing.Command;

/// <summary>
/// Defines the GroupCommand Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.INonVisualDrawingProps))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.INonVisualGroupDrawingShapeProps))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IConnectorMoniker))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IDrawingMonikerList))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IGraphicFrameMoniker))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IGroupShapeMoniker))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IInkMoniker))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IPictureMoniker))]
[ChildElementInfo(typeof(DocumentModel.Office2016.Drawing.Command.IShapeMoniker))]
public interface IGroupCommand // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// verId, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? VerId { get ; set; }
  
  /// <summary>
  /// preventRegroup, this property is only available in Office 2016 and later.
  /// </summary>
  public bool? PreventRegroup { get ; set; }
  
  /// <summary>
  /// grpId, this property is only available in Office 2016 and later.
  /// </summary>
  public uint? GrpId { get ; set; }
  
  /// <summary>
  /// DrawingMonikerList.
  /// </summary>
  public IDrawingMonikerList? DrawingMonikerList { get ; set; }
  
}
