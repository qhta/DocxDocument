namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the ChartSpaceExtension Class.
/// </summary>
[OpenXmlType(typeof(DXDC.ChartSpaceExtension))]
public partial class ChartSpaceExtension: Extension<DXDC.ChartSpaceExtension>
{
  /// <summary>
  /// Options that configure the behavior and appearance of a pivot table.
  /// </summary>
  [OpenXmlElement(typeof(DXO10DC.PivotOptions))]
  public PivotOptions? PivotOptions
  {
    get => _PivotOptions;
    set => UpdateField(ref _PivotOptions, value, nameof(PivotOptions));
  }

  private PivotOptions? _PivotOptions;

  /// <summary>
  /// Options that configure the behavior and appearance of a sketch.
  /// </summary>
  [OpenXmlElement(typeof(DXO10DC.SketchOptions))]
  public SketchOptions? SketchOptions
  {
    get => _SketchOptions;
    set => UpdateField(ref _SketchOptions, value, nameof(SketchOptions));
  }

  private SketchOptions? _SketchOptions;

  /// <summary>
  /// Options that configure the behavior and appearance of a pivot source.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.PivotSource))]
  public PivotSource? PivotSource
  {
    get => _PivotSource;
    set => UpdateField(ref _PivotSource, value, nameof(PivotSource));
  }

  private PivotSource? _PivotSource;
}