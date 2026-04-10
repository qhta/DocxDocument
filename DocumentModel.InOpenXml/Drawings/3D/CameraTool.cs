namespace DocumentModel.Drawings;
/// <summary>
/// Camera tool settings for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXO10D.CameraTool))]
[XmlRoot("CameraTool", Namespace = "DocumentModel.Drawings")]
public partial class CameraTool : ModelElement<DXO10D.CameraTool>
{
 /// <summary>
 /// Cell range.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.CameraTool.CellRange))]
 public string? CellRange { get => _CellRange; set => UpdateField(ref _CellRange, value, nameof(CellRange)); }

 private string? _CellRange;
 /// <summary>
 /// Shape ID.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10D.CameraTool.ShapeId))]
 public string? ShapeId { get => _ShapeId; set => UpdateField(ref _ShapeId, value, nameof(ShapeId)); }

 private string? _ShapeId;
}