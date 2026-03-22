namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a number reference in a chart.
///   This extension allows specifying full references, level references, and formula references for numeric chart data.
/// </summary>
[OpenXmlType(typeof(DXDC.NumRefExtension))]
public partial class NumRefExtension: Extension<DXDC.NumRefExtension>
{
  /// <summary>
  ///   Full reference to the numeric data source.
  /// </summary>
  public FullReference? FullReference
  {
    get => _FullReference;
    set => UpdateField(ref _FullReference, value, nameof(FullReference));
  }
  private FullReference? _FullReference;
  /// <summary>
  ///   Reference to a specific level within the numeric data (if applicable).
  /// </summary>
  public LevelReference? LevelReference
  {
    get => _LevelReference;
    set => UpdateField(ref _LevelReference, value, nameof(LevelReference));
  }
  private LevelReference? _LevelReference;
  /// <summary>
  ///   Formula reference defining the numeric data source dynamic range.
  /// </summary>
  public FormulaReference? FormulaReference
  {
    get => _FormulaReference;
    set => UpdateField(ref _FormulaReference, value, nameof(FormulaReference));
  }
  private FormulaReference? _FormulaReference;
}