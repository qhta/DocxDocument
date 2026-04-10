using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the StringDimension Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.StringDimension))]
[XmlRoot("StringDimension", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class StringDimension : ModelElementCollection<StringLevel, DXO16DCD.StringDimension, DXO16DCD.StringLevel>
{
 /// <summary>
 /// Specifies the type.
 /// </summary>
 public StringDimensionType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private StringDimensionType? _Type;
 /// <summary>
 /// Specifies the formula.
 /// </summary>
 public OpenXmlFormulaElement? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }

 private OpenXmlFormulaElement? _Formula;
 /// <summary>
 /// Specifies the nf formula.
 /// </summary>
 public OpenXmlFormulaElement? NfFormula { get => _NfFormula; set => UpdateField(ref _NfFormula, value, nameof(NfFormula)); }

 private OpenXmlFormulaElement? _NfFormula;
 /// <summary>
 /// Specifies the string level.
 /// </summary>
 public StringLevel? StringLevel { get => _StringLevel; set => UpdateField(ref _StringLevel, value, nameof(StringLevel)); }

 private StringLevel? _StringLevel;
}