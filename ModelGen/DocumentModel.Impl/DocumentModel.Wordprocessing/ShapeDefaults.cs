namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Properties for VML Objects in Main Document.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IShapeDefaults))]
[ChildElementInfo(typeof(DocumentModel.Vml.Office.IShapeLayout))]
public class ShapeDefaults: IShapeDefaults
{
}
