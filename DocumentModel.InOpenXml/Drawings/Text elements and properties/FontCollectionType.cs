namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of font settings for different writing systems, including Latin, East Asian, and complex scripts.
/// </summary>
[OpenXmlType(typeof(DXD.FontCollectionType))]
public partial class FontCollectionType : ModelElement<DXD.FontCollectionType>
{
 /// <summary>
 ///   TextFormat settings for Latin text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontCollectionType.LatinFont))]
 public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }
 private TextFontType? _LatinFont;
 /// <summary>
 ///   TextFormat settings for East Asian text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontCollectionType.EastAsianFont))]
 public TextFontType? EastAsianFont { get => _EastAsianFont; set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont)); }
 private TextFontType? _EastAsianFont;
 /// <summary>
 ///   TextFormat settings for complex script text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontCollectionType.ComplexScriptFont))]
 public TextFontType? ComplexScriptFont { get => _ComplexScriptFont; set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont)); }
 private TextFontType? _ComplexScriptFont;
}