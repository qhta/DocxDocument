using DocumentFormat.OpenXml.EMMA;

namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents text content in a chart, supporting references, rich text, and literals.
/// </summary>
[OpenXmlType(typeof(DXDC.ChartText))]
public class ChartText : ModelElement<DXDC.ChartText>
{
 /// <summary>
 ///   Reference to a string data source.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartText.StringReference))]
 public StringReference? StringReference { get; set; }

 /// <summary>
 ///   Rich text content with formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartText.RichText))]
 public RichText? RichText { get; set; }

 /// <summary>
 ///   Literal string value provided directly.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.ChartText.StringLiteral))]
 public StringLiteral? StringLiteral { get; set; }
}