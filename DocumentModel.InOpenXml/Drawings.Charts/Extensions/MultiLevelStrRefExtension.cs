namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents an extension for a multi-level string reference in a chart.
///   This extension allows specifying full references, level references, and formula references for hierarchical data.
/// </summary>
[OpenXmlType(typeof(DXDC.MultiLvlStrRefExtension))]
public partial class MultiLevelStrRefExtension: Extension<DXDC.MultiLvlStrRefExtension>
{
  /// <summary>
  ///   Full reference to the data source.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FullReference))]
  public FullReference? FullReference
  {
    get => _FullReference;
    set => UpdateField(ref _FullReference, value, nameof(FullReference));
  }

  private FullReference? _FullReference;

  /// <summary>
  ///   Reference to a specific level within the multi-level data.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.LevelReference))]
  public LevelReference? LevelReference
  {
    get => _LevelReference;
    set => UpdateField(ref _LevelReference, value, nameof(LevelReference));
  }

  private LevelReference? _LevelReference;

  /// <summary>
  ///   Formula reference defining the data source dynamic range.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FormulaReference))]
  public FormulaReference? FormulaReference
  {
    get => _FormulaReference;
    set => UpdateField(ref _FormulaReference, value, nameof(FormulaReference));
  }

  private FormulaReference? _FormulaReference;
}