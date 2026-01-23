namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents style conditional table formatting properties for a Wordprocessing document.
/// This class provides access to and management of <see cref="TableStyleProperties"/> elements, enabling advanced conditional formatting and styling for tables based on style rules.
/// </summary>
[OpenXmlType(typeof(DXW.TableStyleConditionalFormattingTableProperties))]
public class TableStyleConditionalProperties: ModelElementCollection<TableStyleProperties, 
  DXW.TableStyleConditionalFormattingTableProperties, DX.OpenXmlElement>
{
}