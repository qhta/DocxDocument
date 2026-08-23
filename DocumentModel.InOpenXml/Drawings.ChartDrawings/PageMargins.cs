namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the PageMargins Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.PageMargins))]
[DataContract]
[XmlRoot("PageMargins", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public partial class PageMargins: ModelElement<DXO16DCD.PageMargins>
{
  /// <summary>
  /// Specifies the l.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PageMargins.L))]
  public Double? L
  {
    get => _L ??= GetProperty<Double?>(GetUpdatableElement()?.L);
    set => UpdateField(ref _L, value, nameof(L));
  }

  private Double? _L;

  /// <summary>
  /// Specifies the r.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PageMargins.R))]
  public Double? R
  {
    get => _R ??= GetProperty<Double?>(GetUpdatableElement()?.R);
    set => UpdateField(ref _R, value, nameof(R));
  }

  private Double? _R;

  /// <summary>
  /// Specifies the t.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PageMargins.T))]
  public Double? T
  {
    get => _T ??= GetProperty<Double?>(GetUpdatableElement()?.T);
    set => UpdateField(ref _T, value, nameof(T));
  }

  private Double? _T;

  /// <summary>
  /// Specifies the b.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PageMargins.B))]
  public Double? B
  {
    get => _B ??= GetProperty<Double?>(GetUpdatableElement()?.B);
    set => UpdateField(ref _B, value, nameof(B));
  }

  private Double? _B;

  /// <summary>
  /// Specifies the header.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PageMargins.Header))]
  public Double? Header
  {
    get => _Header ??= GetProperty<Double?>(GetUpdatableElement()?.Header);
    set => UpdateField(ref _Header, value, nameof(Header));
  }

  private Double? _Header;

  /// <summary>
  /// Specifies the footer.
  /// </summary>
  [OpenXmlProperty(nameof(DXO16DCD.PageMargins.Footer))]
  public Double? Footer
  {
    get => _Footer ??= GetProperty<Double?>(GetUpdatableElement()?.Footer);
    set => UpdateField(ref _Footer, value, nameof(Footer));
  }

  private Double? _Footer;
}