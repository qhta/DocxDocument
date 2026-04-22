namespace DocumentModel.Drawings;
/// <summary>
///   Represents a reference to a predecessor drawing element.
/// </summary>
[OpenXmlType(typeof(DXO16D.PredecessorDrawingElementReference))]
[XmlRoot("PredecessorDrawingElementReference", Namespace = "DocumentModel.Drawings")]
public partial class PredecessorDrawingElementReference : ModelElement<DXO16D.PredecessorDrawingElementReference>
{
 /// <summary>
 ///   Identifier of the predecessor drawing element.
 /// </summary>
 public string? Predecessor { get => _Predecessor; set => UpdateField(ref _Predecessor, value, nameof(Predecessor)); }
 private string? _Predecessor;
}