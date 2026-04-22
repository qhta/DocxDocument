namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the X values for a chart series, including multi-level string references, number references, literals, and string references.
/// </summary>
[OpenXmlType(typeof(DXDC.XValues))]
[XmlRoot("XValues", Namespace = "DocumentModel.Drawings.Charts")]
public partial class XValues : ModelElement<DXDC.XValues>
{
 /// <summary>
 ///   Multi-level string reference for X values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.XValues.MultiLevelStringReference))]
 public MultiLevelStringReference? MultiLevelStringReference { get => _MultiLevelStringReference; set => UpdateField(ref _MultiLevelStringReference, value, nameof(MultiLevelStringReference)); }
 private MultiLevelStringReference? _MultiLevelStringReference;

 /// <summary>
 ///   Reference to the numeric values used for X values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.XValues.NumberReference))]
 public NumberReference? NumberReference { get => _NumberReference; set => UpdateField(ref _NumberReference, value, nameof(NumberReference)); }
 private NumberReference? _NumberReference;

 /// <summary>
 ///   Literal numeric values for X values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.XValues.NumberLiteral))]
 public NumberLiteral? NumberLiteral { get => _NumberLiteral; set => UpdateField(ref _NumberLiteral, value, nameof(NumberLiteral)); }
 private NumberLiteral? _NumberLiteral;

 /// <summary>
 ///   Reference to the string values used for X values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.XValues.StringReference))]
 public StringReference? StringReference { get => _StringReference; set => UpdateField(ref _StringReference, value, nameof(StringReference)); }
 private StringReference? _StringReference;

 /// <summary>
 ///   Literal string values for X values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.XValues.StringLiteral))]
 public StringLiteral? StringLiteral { get => _StringLiteral; set => UpdateField(ref _StringLiteral, value, nameof(StringLiteral)); }
 private StringLiteral? _StringLiteral;
}