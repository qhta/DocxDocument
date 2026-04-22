namespace DocumentModel.Drawings;
/// <summary>
/// Represents a bi-level effect, which applies a threshold to convert an image or shape to strictly two levels (e.g., black and white).
/// </summary>
[OpenXmlType(typeof(DXD.BiLevel))]
[XmlRoot("BiLevel", Namespace = "DocumentModel.Drawings")]
public partial class BiLevel : ModelElement<DXD.BiLevel>
{
 /// <summary>
 /// Threshold value used to determine the separation between the two levels.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.BiLevel.Threshold))]
 public Int32? Threshold { get => _Threshold; set => UpdateField(ref _Threshold, value, nameof(Threshold)); }
 private Int32? _Threshold;
}