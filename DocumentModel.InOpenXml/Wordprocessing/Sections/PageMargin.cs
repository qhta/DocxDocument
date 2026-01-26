namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the page margin settings for a section in a Wordprocessing document.
/// This class provides properties for top, right, bottom, left margins, header and footer spacing, and gutter spacing, enabling advanced configuration of page layout and printing options.
/// </summary>
[OpenXmlType(typeof(DXW.PageMargin))]
public partial class PageMargin : ModelElement<DXW.PageMargin>, ISectionPropertiesContent
{
 /// <summary>
 /// Top margin spacing for the page.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageMargin.Top))]
 /// <summary>
 /// Top margin spacing for the page.
 /// </summary>
 [OpenXmlElement(typeof(DXW.PageMargin))]
 public Twips? Top { get => _Top; set => UpdateField(ref _Top, value, nameof(Top)); }

 private Twips? _Top;
 /// <summary>
 /// Right margin spacing for the page.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageMargin.Right))]
 /// <summary>
 /// Right margin spacing for the page.
 /// </summary>
 [OpenXmlElement(typeof(DXW.PageMargin))]
 public Twips? Right { get => _Right; set => UpdateField(ref _Right, value, nameof(Right)); }

 private Twips? _Right;
 /// <summary>
 /// Bottom margin spacing for the page.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageMargin.Bottom))]
 /// <summary>
 /// Bottom margin spacing for the page.
 /// </summary>
 [OpenXmlElement(typeof(DXW.PageMargin))]
 public Twips? Bottom { get => _Bottom; set => UpdateField(ref _Bottom, value, nameof(Bottom)); }

 private Twips? _Bottom;
 /// <summary>
 /// Left margin spacing for the page.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageMargin.Left))]
 /// <summary>
 /// Left margin spacing for the page.
 /// </summary>
 [OpenXmlElement(typeof(DXW.PageMargin))]
 public Twips? Left { get => _Left; set => UpdateField(ref _Left, value, nameof(Left)); }

 private Twips? _Left;
 /// <summary>
 /// Spacing to the top of the header.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageMargin.Header))]
 /// <summary>
 /// Spacing to the top of the header.
 /// </summary>
 [OpenXmlElement(typeof(DXW.PageMargin))]
 public Twips? Header { get => _Header; set => UpdateField(ref _Header, value, nameof(Header)); }

 private Twips? _Header;
 /// <summary>
 /// Spacing to the bottom of the footer.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageMargin.Footer))]
 /// <summary>
 /// Spacing to the bottom of the footer.
 /// </summary>
 [OpenXmlElement(typeof(DXW.PageMargin))]
 public Twips? Footer { get => _Footer; set => UpdateField(ref _Footer, value, nameof(Footer)); }

 private Twips? _Footer;
 /// <summary>
 /// Page gutter spacing, specifying additional space for binding.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageMargin.Gutter))]
 /// <summary>
 /// Page gutter spacing, specifying additional space for binding.
 /// </summary>
 [OpenXmlElement(typeof(DXW.PageMargin))]
 public Twips? Gutter { get => _Gutter; set => UpdateField(ref _Gutter, value, nameof(Gutter)); }

 private Twips? _Gutter;
}