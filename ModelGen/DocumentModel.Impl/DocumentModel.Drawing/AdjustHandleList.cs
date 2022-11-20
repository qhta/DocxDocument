namespace DocumentModel.Drawing;

/// <summary>
/// List of Shape Adjust Handles.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustHandlePolar))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IAdjustHandleXY))]
public class AdjustHandleList: IAdjustHandleList
{
}
