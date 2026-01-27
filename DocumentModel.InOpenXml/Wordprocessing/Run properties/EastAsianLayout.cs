namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents East Asian typography layout properties for a text run in WordprocessingML documents.
/// This class provides options for two lines in one, bracket display, vertical text rotation, and compression, enabling advanced formatting for East Asian scripts.
/// </summary>
[OpenXmlType(typeof(DXW.EastAsianLayout))]
public partial class EastAsianLayout : ModelElement<DXW.EastAsianLayout>
{
 /// <summary>
 /// Identifier for the East Asian typography run, used to distinguish multiple layout effects within the same document.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EastAsianLayout.Id))]
 public Int32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private Int32? _Id;
 /// <summary>
 /// Indicates whether two lines in one layout is applied, displaying text as two sub-lines within a single line.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EastAsianLayout.Combine))]
 public bool? Combine { get => _Combine; set => UpdateField(ref _Combine, value, nameof(Combine)); }

 private bool? _Combine;
 /// <summary>
 /// Specifies the type of brackets to display around two lines in one layout.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EastAsianLayout.CombineBrackets))]
 public CombineBracketKind? CombineBrackets { get => _CombineBrackets; set => UpdateField(ref _CombineBrackets, value, nameof(CombineBrackets)); }

 private CombineBracketKind? _CombineBrackets;
 /// <summary>
 /// Indicates whether horizontal text is rotated for vertical layout.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EastAsianLayout.Vertical))]
 public bool? Vertical { get => _Vertical; set => UpdateField(ref _Vertical, value, nameof(Vertical)); }

 private bool? _Vertical;
 /// <summary>
 /// Indicates whether rotated text is compressed to fit the line height in vertical layout.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.EastAsianLayout.VerticalCompress))]
 public bool? VerticalCompress { get => _VerticalCompress; set => UpdateField(ref _VerticalCompress, value, nameof(VerticalCompress)); }

 private bool? _VerticalCompress;
}