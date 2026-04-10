namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the data source for numeric values in a chart.
///   This class allows specifying either a reference to an external data source or literal values provided directly.
/// </summary>
[OpenXmlType(typeof(DXDC.NumberDataSourceType))]
[XmlRoot("NumberDataSourceType", Namespace = "DocumentModel.Drawings.Charts")]
public partial class NumberDataSourceType : ModelElement<DXDC.NumberDataSourceType>
{
 /// <summary>
 ///   Reference to a numeric data source, typically used for formula-based values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberDataSourceType.NumberReference))]
 public NumberReference? NumberReference { get => _NumberReference; set => UpdateField(ref _NumberReference, value, nameof(NumberReference)); }

 private NumberReference? _NumberReference;
 /// <summary>
 ///   Literal numeric values provided directly for the data source.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberDataSourceType.NumberLiteral))]
 public NumberLiteral? NumberLiteral { get => _NumberLiteral; set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral)); }

 private NumberLiteral? _NumberLiteral;
}