namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Page Margins.
/// </summary>
[OpenXmlType(typeof(DXDC.PageMargins))]
public partial class PageMargins: ModelElement<DXDC.PageMargins>
{
  /// <summary>
  ///   Left
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PageMargins.Left))]
  public Double? Left { get => _Left; set => UpdateField(ref _Left, value, nameof(Left)); }

  private Double? _Left;

  /// <summary>
  ///   Right
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PageMargins.Right))]
  public Double? Right { get => _Right; set => UpdateField(ref _Right, value, nameof(Right)); }

  private Double? _Right;

  /// <summary>
  ///   Top
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PageMargins.Top))]
  public Double? Top { get => _Top; set => UpdateField(ref _Top, value, nameof(Top)); }

  private Double? _Top;

  /// <summary>
  ///   Bottom
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PageMargins.Bottom))]
  public Double? Bottom { get => _Bottom; set => UpdateField(ref _Bottom, value, nameof(Bottom)); }

  private Double? _Bottom;

  /// <summary>
  ///   Header
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PageMargins.Header))]
  public Double? Header { get => _Header; set => UpdateField(ref _Header, value, nameof(Header)); }

  private Double? _Header;

  /// <summary>
  ///   Footer
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.PageMargins.Footer))]
  public Double? Footer { get => _Footer; set => UpdateField(ref _Footer, value, nameof(Footer)); }

  private Double? _Footer;
}