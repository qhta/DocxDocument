namespace DocumentModel.Drawings;

/// <summary>
/// Represents background properties, including black and white rendering modes and target screen size for display.
/// </summary>
[OpenXmlType(typeof(DXO13D.BackgroundProperties))]
[DataContract]
[XmlRoot("BackgroundProperties", Namespace = "DocumentModel.Drawings")]
public partial class BackgroundProperties: ModelElement<DXO13D.BackgroundProperties>
{
  /// <summary>
  /// Gets or sets the black and white mode for background rendering.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13D.BackgroundProperties.Mode))]
  public BlackWhiteMode? Mode
  {
    get => _Mode ??= GetProperty<BlackWhiteMode?>(GetUpdatableElement()?.Mode);
    set => UpdateField(ref _Mode, value, nameof(Mode));
  }
  private BlackWhiteMode? _Mode;

  /// <summary>
  /// Gets or sets the pure black and white mode for background rendering.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13D.BackgroundProperties.Pure))]
  public BlackWhiteMode? Pure
  {
    get => _Pure ??= GetProperty<BlackWhiteMode?>(GetUpdatableElement()?.Pure);
    set => UpdateField(ref _Pure, value, nameof(Pure));
  }
  private BlackWhiteMode? _Pure;

  /// <summary>
  /// Gets or sets the normal black and white mode for background rendering.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13D.BackgroundProperties.Normal))]
  public BlackWhiteMode? Normal
  {
    get => _Normal ??= GetProperty<BlackWhiteMode?>(GetUpdatableElement()?.Normal);
    set => UpdateField(ref _Normal, value, nameof(Normal));
  }
  private BlackWhiteMode? _Normal;

  /// <summary>
  /// Gets or sets the target screen size for which the background is optimized.
  /// </summary>
  [OpenXmlProperty(nameof(DXO13D.BackgroundProperties.TargetScreenSize))]
  public TargetScreenSize? TargetScreenSize
  {
    get => _TargetScreenSize ??= GetProperty<TargetScreenSize?>(GetUpdatableElement()?.TargetScreenSize);
    set => UpdateField(ref _TargetScreenSize, value, nameof(TargetScreenSize));
  }
  private TargetScreenSize? _TargetScreenSize;
}