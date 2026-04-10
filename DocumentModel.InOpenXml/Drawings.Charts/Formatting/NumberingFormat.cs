namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents the number formatting options for chart values or labels.
///   This class allows specifying a custom format code and whether the format is linked to the source data.
/// </summary>
[XmlRoot("NumberingFormat", Namespace = "DocumentModel.Drawings.Charts")]
public class NumberingFormat<T> : ModelElement<T> where T : DX.OpenXmlElement
{
 /// <summary>
 ///   Format code that defines how numbers are displayed, such as currency, percentage, or custom patterns.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberingFormat.FormatCode))]
 public string? FormatCode { get; set; }

 /// <summary>
 ///   Indicates whether the number format is linked to the source data.
 ///   If true, the format will automatically update to match the source.
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.NumberingFormat.SourceLinked))]
 public bool? SourceLinked { get; set; }
}

/// <summary>
/// Represents the numbering format for a document element in the DocumentFormat.OpenXml.Drawing.Charts namespace.
/// </summary>
[OpenXmlType(typeof(DXDC.NumberingFormat))]
[XmlRoot("NumberingFormat", Namespace = "DocumentModel.Drawings.Charts")]
public class NumberingFormat : NumberingFormat<DXDC.NumberingFormat>
{
}

/// <summary>
/// Represents the numbering format for a document element in the DocumentFormat.OpenXml.Office2013.Drawing.Charts namespace.
/// </summary>
[OpenXmlType(typeof(DXO13DC.NumberingFormat))]
[XmlRoot("NumberingFormat3", Namespace = "DocumentModel.Drawings.Charts")]
public class NumberingFormat3 : NumberingFormat<DXO13DC.NumberingFormat>
{
}