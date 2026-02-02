namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the document grid settings for a section in a WordprocessingML document.
/// This class extends <see cref = "SectionPropertiesContent"/> and provides properties for grid type, line pitch, and character pitch, enabling advanced control over text layout, alignment, and grid-based formatting in East Asian and other grid-based document scenarios.
/// </summary>
[OpenXmlType(typeof(DXW.DocGrid))]
public partial class DocGrid : ModelElement<DXW.DocGrid>, ISectionPropertiesContent
{
 /// <summary>
 /// Document grid type, specifying the kind of grid used for text layout (e.g., none, lines, lines and characters, snap to characters).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocGrid.Type))]
 public DocGridType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private DocGridType? _Type;
 /// <summary>
 /// Line pitch for the document grid, specifying the vertical spacing between grid lines in twips.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocGrid.LinePitch))]
 public Twips? LinePitch { get => _LinePitch; set => UpdateField(ref _LinePitch, value, nameof(LinePitch)); }

 private Twips? _LinePitch;
 /// <summary>
 /// Character pitch for the document grid, specifying the horizontal spacing between grid characters in twips.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocGrid.CharacterSpace))]
 public Twips? CharacterSpace { get => _CharacterSpace; set => UpdateField(ref _CharacterSpace, value, nameof(CharacterSpace)); }

 private Twips? _CharacterSpace;
}