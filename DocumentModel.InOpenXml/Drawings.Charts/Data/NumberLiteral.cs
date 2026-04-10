namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a set of literal numeric values for a chart.
/// </summary>
[OpenXmlType(typeof(DXDC.NumberLiteral))]
[XmlRoot("NumberLiteral", Namespace = "DocumentModel.Drawings.Charts")]
public partial class NumberLiteral : ModelElement<DXDC.NumberLiteral>
{
 /// <summary>
 ///   Format code applied to the numeric values.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberLiteral.FormatCode))]
 public string? FormatCode { get => _FormatCode; set => UpdateField(ref _FormatCode, value, nameof(FormatCode)); }

 private string? _FormatCode;
 /// <summary>
 ///   Number of numeric points in the literal value set.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberLiteral.PointCount))]
 public UInt32? PointCount { get => _PointCount; set => UpdateField(ref _PointCount, value, nameof(PointCount)); }

 private UInt32? _PointCount;
 /// <summary>
 ///   Collection of numeric points containing the literal values.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.NumericPoint))]
 public NumericPoints? NumericPoints { get => _NumericPoints; set => UpdateField(ref _NumericPoints, value, nameof(NumericPoints)); }

 private NumericPoints? _NumericPoints;
 /// <summary>
 ///   Collection of extension elements for additional customization.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.ExtensionList))]
 public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

 private ExtensionList? _ExtensionList;
}