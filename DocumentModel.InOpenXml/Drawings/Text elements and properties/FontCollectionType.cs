namespace DocumentModel.Drawings;
/// <summary>
///   Represents a collection of font settings for different writing systems, including Latin, East Asian, and complex scripts.
/// </summary>
[OpenXmlType(typeof(DXD.FontCollectionType))]
public partial class FontCollectionType : ModelElement<DXD.FontCollectionType>
{
 /// <summary>
 ///   Font settings for Latin text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontCollectionType.LatinFont))]
 /// <summary>
 ///   Font settings for Latin text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontCollectionType))]
 public TextFontType? LatinFont { get => _LatinFont; set => UpdateField(ref _LatinFont, value, nameof(LatinFont)); }

 private TextFontType? _LatinFont;
 /// <summary>
 ///   Font settings for East Asian text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontCollectionType.EastAsianFont))]
 /// <summary>
 ///   Font settings for East Asian text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontCollectionType))]
 public TextFontType? EastAsianFont { get => _EastAsianFont; set => UpdateField(ref _EastAsianFont, value, nameof(EastAsianFont)); }

 private TextFontType? _EastAsianFont;
 /// <summary>
 ///   Font settings for complex script text.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.FontCollectionType.ComplexScriptFont))]
 /// <summary>
 ///   Font settings for complex script text.
 /// </summary>
 [OpenXmlElement(typeof(DXD.FontCollectionType))]
 public TextFontType? ComplexScriptFont { get => _ComplexScriptFont; set => UpdateField(ref _ComplexScriptFont, value, nameof(ComplexScriptFont)); }

 private TextFontType? _ComplexScriptFont;
}