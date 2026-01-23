namespace DocumentModel.Drawings;
/// <summary>
/// Camera tool settings for drawing elements.
/// </summary>
public partial class CameraTool : ModelElement<DXO10D.CameraTool>
{
    /// <summary>
    /// Cell range.
    /// </summary>
    public string? CellRange { get => _CellRange; set => UpdateField(ref _CellRange, value, nameof(CellRange)); }

    private string? _CellRange;
    /// <summary>
    /// Shape ID.
    /// </summary>
    public string? ShapeId { get => _ShapeId; set => UpdateField(ref _ShapeId, value, nameof(ShapeId)); }

    private string? _ShapeId;
}