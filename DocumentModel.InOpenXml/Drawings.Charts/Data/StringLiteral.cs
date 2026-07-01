namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a set of literal string values for a chart.
///   This class allows defining string data directly within the chart definition, rather than referencing an external source.
/// </summary>
[OpenXmlType(typeof(DXDC.StringLiteral))]
[DataContract]
[XmlRoot("StringLiteral", Namespace = "DocumentModel.Drawings.Charts")]
public partial class StringLiteral : ModelElement<DXDC.StringLiteral>
{
 /// <summary>
 ///   Number of string points in the literal value set.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.StringLiteral.PointCount))]
 public UInt32? PointCount { get => _PointCount; set => UpdateField(ref _PointCount, value, nameof(PointCount)); }
 private UInt32? _PointCount;

 /// <summary>
 ///   Collection of string points containing the literal values.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.StringPoint))]
 public StringPoints? StringPoints { get => _StringPoints; set => UpdateField(ref _StringPoints, value, nameof(StringPoints)); }
 private StringPoints? _StringPoints;

 /// <summary>
 ///   Extension element for additional customization.
 /// </summary>
 [OpenXmlElement(typeof(DXDC.StrDataExtensionList))]
 public StrDataExtension? StrDataExtension { get => _StrDataExtension; set => UpdateField(ref _StrDataExtension, value, nameof(StrDataExtension)); }
 private StrDataExtension? _StrDataExtension;
}