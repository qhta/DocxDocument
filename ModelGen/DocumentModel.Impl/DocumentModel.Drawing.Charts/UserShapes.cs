namespace DocumentModel.Drawing.Charts;

/// <summary>
/// User Shapes.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IAbsoluteAnchorSize))]
[ChildElementInfo(typeof(DocumentModel.Drawing.ChartDrawing.IRelativeAnchorSize))]
public class UserShapes: IUserShapes
{
}
