namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents run properties declared in a table style for a Wordprocessing document.
/// This class provides formatting options for text runs within tables, such as font, size, color, and effects, enabling advanced styling and conditional formatting for table content.
/// </summary>
[OpenXmlType(typeof(DXW.RunProperties))]
public class TableStyleRunProperties : ExtBaseRunProperties<DXW.RunProperties>
{
}