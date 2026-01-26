namespace DocumentModel;
/// <summary>
/// Represents an RGB color using hexadecimal notation for Wordprocessing.
/// </summary>
[OpenXmlType(typeof(DXD.RgbColorModelHex))]
public partial class RgbColor : Color<DXD.RgbColorModelHex>
{
 /// <summary>
 /// Gets or sets the base RGB color value in hexadecimal format.
 /// </summary>
 /// <remarks>
 /// <para>
 /// This is the primary color value specified as a 24-bit RGB color. The hexadecimal format
 /// provides a compact and familiar way to specify colors, matching standard web/CSS notation.
 /// </para>
 /// <para>
 /// Documents using RGB colors
 /// with transformations require compatibility with Office 2010 or higher to display correctly.
 /// In earlier versions, only the base RGB value may be displayed without transformations.
 /// </para>
 /// </remarks>
 public RGB? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

 private RGB? _Val;
}