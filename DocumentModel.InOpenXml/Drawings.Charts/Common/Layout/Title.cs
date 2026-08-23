namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Title.
/// </summary>
[OpenXmlType(typeof(DXDC.Title))]
[DataContract]
[XmlRoot("Title", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Title: ModelElement<DXDC.Title>
{
  /// <summary>
  ///   Chart Text.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Title.ChartText))]
  public ChartText? ChartText
  {
    get => _ChartText ??= GetProperty<ChartText?>(GetUpdatableElement()?.ChartText);
    set => UpdateField(ref _ChartText, value, nameof(ChartText));
  }

  private ChartText? _ChartText;

  /// <summary>
  ///   Layout.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Title.Layout))]
  public Layout? Layout
  {
    get => _Layout ??= GetProperty<Layout?>(GetUpdatableElement()?.Layout);
    set => UpdateField(ref _Layout, value, nameof(Layout));
  }

  private Layout? _Layout;

  /// <summary>
  ///   Overlay.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Title.Overlay))]
  public bool? Overlay
  {
    get => _Overlay ??= GetProperty<bool?>(GetUpdatableElement()?.Overlay);
    set => UpdateField(ref _Overlay, value, nameof(Overlay));
  }

  private bool? _Overlay;

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Title.ChartShapeProperties))]
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties ??= GetProperty<ChartShapeProperties?>(GetUpdatableElement()?.ChartShapeProperties);
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }

  private ChartShapeProperties? _ChartShapeProperties;

  /// <summary>
  ///   TextProperties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Title.TextProperties))]
  public TextProperties? TextProperties
  {
    get => _TextProperties ??= GetProperty<TextProperties?>(GetUpdatableElement()?.TextProperties);
    set => UpdateField(ref _TextProperties, value, nameof(TextProperties));
  }

  private TextProperties? _TextProperties;

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.Title.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}