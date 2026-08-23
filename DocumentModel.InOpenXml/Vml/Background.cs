namespace DocumentModel.Vml;

/// <summary>
///   Document Background.
/// </summary>
[OpenXmlType(typeof(DXV.Background))]
[DataContract]
[XmlRoot("Background", Namespace = "DocumentModel.Vml")]
public partial class Background: ModelElement<DXV.Background>
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.Filled))]
  public bool? Filled
  {
    get => _Filled ??= GetProperty<bool?>(GetUpdatableElement()?.Filled);
    set => UpdateField(ref _Filled, value, nameof(Filled));
  }

  private bool? _Filled;

  /// <summary>
  ///   Fill Color
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.Fillcolor))]
  public VmlColor? FillColor
  {
    get => _fillColor ??= GetProperty<VmlColor?>(GetUpdatableElement()?.Fillcolor);
    set => UpdateField(ref _fillColor, value, nameof(FillColor));
  }

  private VmlColor? _fillColor;

  /// <summary>
  ///   Black-and-White Mode
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.BlackWhiteMode))]
  public BlackAndWhiteMode? BlackWhiteMode
  {
    get => _BlackWhiteMode ??= GetProperty<BlackAndWhiteMode?>(GetUpdatableElement()?.BlackWhiteMode);
    set => UpdateField(ref _BlackWhiteMode, value, nameof(BlackWhiteMode));
  }

  private BlackAndWhiteMode? _BlackWhiteMode;

  /// <summary>
  ///   Pure Black-and-White Mode
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.PureBlackWhiteMode))]
  public BlackAndWhiteMode? PureBlackWhiteMode
  {
    get => _PureBlackWhiteMode ??= GetProperty<BlackAndWhiteMode?>(GetUpdatableElement()?.PureBlackWhiteMode);
    set => UpdateField(ref _PureBlackWhiteMode, value, nameof(PureBlackWhiteMode));
  }

  private BlackAndWhiteMode? _PureBlackWhiteMode;

  /// <summary>
  ///   Normal Black-and-White Mode
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.NormalBlackWhiteMode))]
  public BlackAndWhiteMode? NormalBlackWhiteMode
  {
    get => _NormalBlackWhiteMode ??= GetProperty<BlackAndWhiteMode?>(GetUpdatableElement()?.NormalBlackWhiteMode);
    set => UpdateField(ref _NormalBlackWhiteMode, value, nameof(NormalBlackWhiteMode));
  }

  private BlackAndWhiteMode? _NormalBlackWhiteMode;

  /// <summary>
  ///   Target Screen Size
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.TargetScreenSize))]
  public ScreenSize? TargetScreenSize
  {
    get => _TargetScreenSize ??= GetProperty<ScreenSize?>(GetUpdatableElement()?.TargetScreenSize);
    set => UpdateField(ref _TargetScreenSize, value, nameof(TargetScreenSize));
  }

  private ScreenSize? _TargetScreenSize;

  /// <summary>
  ///   Fill.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Background.Fill))]
  public Fill? Fill
  {
    get => _Fill ??= GetProperty<Fill?>(GetUpdatableElement()?.Fill);
    set => UpdateField(ref _Fill, value, nameof(Fill));
  }

  private Fill? _Fill;
}