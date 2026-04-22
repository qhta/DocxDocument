namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a full reference to a data source range.
/// </summary>
[OpenXmlType(typeof(DXO13DC.FullReference))]
[XmlRoot("FullReference", Namespace = "DocumentModel.Drawings.Charts")]
public partial class FullReference : ModelElement<DXO13DC.FullReference>
{
 /// <summary>
 ///   Sequence of references defining the full data range.
 /// </summary>
 [OpenXmlProperty(nameof(DXO13DC.FullReference.SequenceOfReferences))]
 public string? SequenceOfReferences { get => _SequenceOfReferences; set => UpdateField(ref _SequenceOfReferences, value, nameof(SequenceOfReferences)); }
 private string? _SequenceOfReferences;
}