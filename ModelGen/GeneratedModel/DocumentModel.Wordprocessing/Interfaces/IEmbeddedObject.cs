namespace DocumentModel.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IOleObject))]
[ChildElementInfo(typeof(DocumentModel.Vml.IArc))]
[ChildElementInfo(typeof(DocumentModel.Vml.ICurve))]
[ChildElementInfo(typeof(DocumentModel.Vml.IGroup))]
[ChildElementInfo(typeof(DocumentModel.Vml.IImageFile))]
[ChildElementInfo(typeof(DocumentModel.Vml.ILine))]
[ChildElementInfo(typeof(DocumentModel.Vml.IOval))]
[ChildElementInfo(typeof(DocumentModel.Vml.IPolyLine))]
[ChildElementInfo(typeof(DocumentModel.Vml.IRectangle))]
[ChildElementInfo(typeof(DocumentModel.Vml.IRoundRectangle))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShape))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShapetype))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IControl))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IDrawing))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IObjectEmbed))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IObjectLink))]
public interface IEmbeddedObject // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// dxaOrig
  /// </summary>
  public string? DxaOriginal { get ; set; }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  public string? DyaOriginal { get ; set; }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public IHexBinaryValue? AnchorId { get ; set; }
  
}
