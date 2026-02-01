namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a style set in a Wordprocessing document.
/// This class provides properties for the style set identifier and value, enabling management and configuration of style sets for document formatting.
/// </summary>
[OpenXmlType(typeof(DXO10W.StyleSet))]
public partial class StyleSet : ModelElement<DXO10W.StyleSet>
{
 /// <summary>
 /// Identifier for the style set.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.StyleSet.Id))]
 public UInt32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private UInt32? _Id;
 /// <summary>
 /// Value indicating the state or setting of the style set.
 /// </summary>
 [OpenXmlProperty(nameof(DXO10W.StyleSet.Val))]
 public Boolean? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

 private Boolean? _Val;
}