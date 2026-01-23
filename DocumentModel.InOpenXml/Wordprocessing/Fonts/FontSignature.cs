namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the font signature information for an embedded font in a WordprocessingML document.
/// This class provides properties for Unicode subset and code page bitfields, enabling advanced identification and compatibility checks for font usage and character support.
/// </summary>
public class FontSignature : ModelElement<DXW.FontSignature>
{
    /// <summary>
    /// First 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb0).
    /// </summary>
    [XmlAttribute("usb0")]
    /// <summary>
    /// First 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb0).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FontSignature.UnicodeSignature0))]
    /// <summary>
    /// First 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb0).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FontSignature))]
    public HexInt UnicodeSignature0 { get => Items[0]; set => Items[0] = value; }

    /// <summary>
    /// Second 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb1).
    /// </summary>
    [XmlAttribute("usb1")]
    /// <summary>
    /// Second 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb1).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FontSignature.UnicodeSignature1))]
    /// <summary>
    /// Second 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb1).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FontSignature))]
    public HexInt UnicodeSignature1 { get => Items[1]; set => Items[1] = value; }

    /// <summary>
    /// Third 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb2).
    /// </summary>
    [XmlAttribute("usb2")]
    /// <summary>
    /// Third 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb2).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FontSignature.UnicodeSignature2))]
    /// <summary>
    /// Third 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb2).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FontSignature))]
    public HexInt UnicodeSignature2 { get => Items[2]; set => Items[2] = value; }

    /// <summary>
    /// Fourth 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb3).
    /// </summary>
    [XmlAttribute("usb3")]
    /// <summary>
    /// Fourth 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb3).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FontSignature.UnicodeSignature3))]
    /// <summary>
    /// Fourth 32 bits of the Unicode subset bitfield, indicating supported Unicode ranges (usb3).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FontSignature))]
    public HexInt UnicodeSignature3 { get => Items[3]; set => Items[3] = value; }

    /// <summary>
    /// Lower 32 bits of the code page bitfield, indicating supported code pages (csb0).
    /// </summary>
    [XmlAttribute("csb0")]
    /// <summary>
    /// Lower 32 bits of the code page bitfield, indicating supported code pages (csb0).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FontSignature.CodePageSignature0))]
    /// <summary>
    /// Lower 32 bits of the code page bitfield, indicating supported code pages (csb0).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FontSignature))]
    public HexInt CodePageSignature0 { get => Items[4]; set => Items[4] = value; }

    /// <summary>
    /// Upper 32 bits of the code page bitfield, indicating supported code pages (csb1).
    /// </summary>
    [XmlAttribute("csb1")]
    /// <summary>
    /// Upper 32 bits of the code page bitfield, indicating supported code pages (csb1).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.FontSignature.CodePageSignature1))]
    /// <summary>
    /// Upper 32 bits of the code page bitfield, indicating supported code pages (csb1).
    /// </summary>
    [OpenXmlElement(typeof(DXW.FontSignature))]
    public HexInt CodePageSignature1 { get => Items[5]; set => Items[5] = value; }

    /// <summary>
    /// Array collecting all six parts of the font signature (Unicode and code page bitfields).
    /// </summary>
    [XmlIgnore]
    public HexInt[] Items = new HexInt[6];
}