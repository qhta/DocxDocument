namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PictureBulletBase Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.IGroup))]
[ChildElementInfo(typeof(DocumentModel.Vml.IImageFile))]
[ChildElementInfo(typeof(DocumentModel.Vml.ILine))]
[ChildElementInfo(typeof(DocumentModel.Vml.IOval))]
[ChildElementInfo(typeof(DocumentModel.Vml.IPolyLine))]
[ChildElementInfo(typeof(DocumentModel.Vml.IRectangle))]
[ChildElementInfo(typeof(DocumentModel.Vml.IRoundRectangle))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShape))]
[ChildElementInfo(typeof(DocumentModel.Vml.IShapetype))]
public class PictureBulletBase: IPictureBulletBase
{
}
