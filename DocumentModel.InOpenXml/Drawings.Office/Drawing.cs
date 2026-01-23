namespace DocumentModel.Drawings.Office;
/// <summary>
///   Defines the Drawing Class.
/// </summary>
public partial class Drawing : ModelElement<DXOD.Drawing>
{
    /// <summary>
    ///   ShapeTree.
    /// </summary>
    [OpenXmlProperty(nameof(DXOD.Drawing.ShapeTree))]
    public ShapeTree? ShapeTree { get => _ShapeTree; set => UpdateField(ref _ShapeTree, value, nameof(ShapeTree)); }

    private ShapeTree? _ShapeTree;
}