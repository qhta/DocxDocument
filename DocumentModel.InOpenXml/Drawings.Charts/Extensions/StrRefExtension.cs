namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents an extension for a string reference in a chart.
///   This extension allows specifying full references, level references, and formula references for string chart data.
/// </summary>
[OpenXmlType(typeof(DXDC.StrRefExtension))]
public partial class StrRefExtension: Extension<DXDC.StrRefExtension>
{
  /// <summary>
  ///   Full reference to the string data source.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FullReference))]
  public FullReference? FullReference
  {
    get => _FullReference;
    set => UpdateField(ref _FullReference, value, nameof(FullReference));
  }
  private FullReference? _FullReference;
  /// <summary>
  ///   Reference to a specific level within the string data (if applicable).
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.LevelReference))]
  public LevelReference? LevelReference
  {
    get => _LevelReference;
    set => UpdateField(ref _LevelReference, value, nameof(LevelReference));
  }
  private LevelReference? _LevelReference;
  /// <summary>
  ///   Formula reference defining the string data source dynamic range.
  /// </summary>
  [OpenXmlElement(typeof(DXO13DC.FormulaReference))]
  public FormulaReference? FormulaReference
  {
    get => _FormulaReference;
    set => UpdateField(ref _FormulaReference, value, nameof(FormulaReference));
  }
  private FormulaReference? _FormulaReference;
}