namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines options for the sketch mode configuration of a chart.
/// </summary>
[OpenXmlType(typeof(DXO10DC.SketchOptions))]
public partial class SketchOptions: ModelElement<DXO10DC.SketchOptions>
{
  /// <summary>
  /// Boolean value indicating whether the chart is currently rendered in sketch mode.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DC.SketchOptions.InSketchMode))]
  public bool? InSketchMode
  {
    get => _InSketchMode;
    set => UpdateField(ref _InSketchMode, value, nameof(InSketchMode));
  }

  private bool? _InSketchMode;

  /// <summary>
  /// Boolean value specifying if the sketch mode button should be visible in the user class.
  /// </summary>
  [OpenXmlProperty(nameof(DXO10DC.SketchOptions.ShowSketchButton))]
  public bool? ShowSketchButton
  {
    get => _ShowSketchButton;
    set => UpdateField(ref _ShowSketchButton, value, nameof(ShowSketchButton));
  }

  private bool? _ShowSketchButton;
}