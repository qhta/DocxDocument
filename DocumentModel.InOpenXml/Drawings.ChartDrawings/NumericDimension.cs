using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the NumericDimension Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.NumericDimension))]
public class NumericDimension: ModelElementCollection<NumericLevel, DXO16DCD.NumericDimension, DXO16DCD.NumericLevel>
{
  /// <summary>
  /// Specifies the type.
  /// </summary>
  public NumericDimensionType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
  private NumericDimensionType? _Type;
  /// <summary>
  /// Specifies the formula.
  /// </summary>
  public OpenXmlFormulaElement? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }
  private OpenXmlFormulaElement? _Formula;
  /// <summary>
  /// Specifies the nf formula.
  /// </summary>
  public OpenXmlFormulaElement? NfFormula
  {
    get => _NfFormula;
    set => UpdateField(ref _NfFormula, value, nameof(NfFormula));
  }
  private OpenXmlFormulaElement? _NfFormula;
  /// <summary>
  /// Specifies the numeric level.
  /// </summary>
  public NumericLevel? NumericLevel
  {
    get => _NumericLevel;
    set => UpdateField(ref _NumericLevel, value, nameof(NumericLevel));
  }
  private NumericLevel? _NumericLevel;
}