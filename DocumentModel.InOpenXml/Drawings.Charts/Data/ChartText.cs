using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents text content in a chart, supporting references, rich text, and literals.
/// </summary>
[OpenXmlType(typeof(DXDC.ChartText))]
[XmlRoot("ChartText", Namespace = "DocumentModel.Drawings.Charts")]
public partial class ChartText : ModelElement<DXDC.ChartText>
{
 /// <summary>
 ///   Reference to a string data source.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartText.StringReference))]
 public StringReference? StringReference { get => _StringReference; set => UpdateField(ref _StringReference, value, nameof(StringReference)); }

 private StringReference? _StringReference;
 /// <summary>
 ///   Rich text content with formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartText.RichText))]
 public RichText? RichText { get => _RichText; set => UpdateField(ref _RichText, value, nameof(RichText)); }

 private RichText? _RichText;
 /// <summary>
 ///   Literal string value provided directly.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartText.StringLiteral))]
 public StringLiteral? StringLiteral { get => _StringLiteral; set => UpdateField(ref _StringLiteral, value, nameof(StringLiteral)); }

 private StringLiteral? _StringLiteral;
}