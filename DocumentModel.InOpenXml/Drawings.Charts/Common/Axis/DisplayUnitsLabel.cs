namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Display Units Label.
/// </summary>
[OpenXmlType(typeof(DXDC.DisplayUnitsLabel))]
public partial class DisplayUnitsLabel: ModelElement<DXDC.DisplayUnitsLabel>
{
  /// <summary>
  ///   Layout.
  /// </summary>
  public Layout? Layout { get => _Layout; set => UpdateField(ref _Layout, value, nameof(Layout)); }
  private Layout? _Layout;
  /// <summary>
  ///   ChartText.
  /// </summary>
  public ChartText? ChartText { get => _ChartText; set => UpdateField(ref _ChartText, value, nameof(ChartText)); }
  private ChartText? _ChartText;
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get => _ChartShapeProperties;
    set => UpdateField(ref _ChartShapeProperties, value, nameof(ChartShapeProperties));
  }
  private ChartShapeProperties? _ChartShapeProperties;
  /// <summary>
  ///   TextProperties.
  /// </summary>
  public TextProperties? TextProperties
  {
    get => _TextProperties;
    set => UpdateField(ref _TextProperties, value, nameof(TextProperties));
  }
  private TextProperties? _TextProperties;
}