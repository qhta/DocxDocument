namespace DocumentModel.Drawings;
/// <summary>
///   Represents a supplemental font for a specific script, including script identifier and typeface.
/// </summary>
[OpenXmlType(typeof(DXD.SupplementalFont))]
public partial class SupplementalFont : ModelElement<DXD.SupplementalFont>
{
 /// <summary>
 ///   Script identifier for which the font is used.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.SupplementalFont.Script))]
 [OpenXmlElement(typeof(DXD.SupplementalFont))]
 public string? Script { get => _Script; set => UpdateField(ref _Script, value, nameof(Script)); }

 private string? _Script;
 /// <summary>
 ///   Typeface name for the specified script.
 /// </summary>
 [OpenXmlProperty(nameof(DXD.SupplementalFont.Typeface))]
 [OpenXmlElement(typeof(DXD.SupplementalFont))]
 public string? Typeface { get => _Typeface; set => UpdateField(ref _Typeface, value, nameof(Typeface)); }

 private string? _Typeface;
}