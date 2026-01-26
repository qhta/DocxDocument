namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents style conditional table formatting properties for a table in a Wordprocessing document.
/// This class provides properties for conditional formatting type, paragraph and run properties, and conditional formatting for tables, rows, and cells, enabling advanced styling and formatting options based on table style rules.
/// </summary>
[OpenXmlType(typeof(DXW.TableStyleProperties))]
public partial class TableStyleProperties : ModelElement<DXW.TableStyleProperties>
{
 /// <summary>
 /// Table style conditional formatting type, specifying the override kind for conditional formatting.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableStyleProperties.Type))]
 /// <summary>
 /// Table style conditional formatting type, specifying the override kind for conditional formatting.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableStyleProperties))]
 public TableStyleOverrideKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private TableStyleOverrideKind? _Type;
 /// <summary>
 /// Table style conditional formatting paragraph properties, specifying formatting for paragraphs within the table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableStyleProperties.StyleParagraphProperties))]
 /// <summary>
 /// Table style conditional formatting paragraph properties, specifying formatting for paragraphs within the table.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableStyleProperties))]
 public StyleParagraphProperties? StyleParagraphProperties { get => _StyleParagraphProperties; set => UpdateField(ref _StyleParagraphProperties, value, nameof(StyleParagraphProperties)); }

 private StyleParagraphProperties? _StyleParagraphProperties;
 /// <summary>
 /// Table style conditional formatting run properties, specifying formatting for text runs within the table.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableStyleProperties))]
 public TableStyleRunProperties? TableStyleRunProperties { get => _TableStyleRunProperties; set => UpdateField(ref _TableStyleRunProperties, value, nameof(TableStyleRunProperties)); }

 private TableStyleRunProperties? _TableStyleRunProperties;
 /// <summary>
 /// Table style conditional formatting table properties, specifying formatting for the table as a whole.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableStyleProperties))]
 public TableStyleConditionalTableProperties? TableStyleConditionalTableProperties { get => _TableStyleConditionalTableProperties; set => UpdateField(ref _TableStyleConditionalTableProperties, value, nameof(TableStyleConditionalTableProperties)); }

 private TableStyleConditionalTableProperties? _TableStyleConditionalTableProperties;
 /// <summary>
 /// Table style conditional formatting table row properties, specifying formatting for individual rows.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableStyleProperties))]
 public TableStyleConditionalRowProperties? TableStyleConditionalRowProperties { get => _TableStyleConditionalRowProperties; set => UpdateField(ref _TableStyleConditionalRowProperties, value, nameof(TableStyleConditionalRowProperties)); }

 private TableStyleConditionalRowProperties? _TableStyleConditionalRowProperties;
 /// <summary>
 /// Table style conditional formatting table cell properties, specifying formatting for individual cells.
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableStyleProperties))]
 public TableStyleConditionalCellProperties? TableStyleConditionalCellProperties { get => _TableStyleConditionalCellProperties; set => UpdateField(ref _TableStyleConditionalCellProperties, value, nameof(TableStyleConditionalCellProperties)); }

 private TableStyleConditionalCellProperties? _TableStyleConditionalCellProperties;
}