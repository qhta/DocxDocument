namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the table layout settings for a table in a Wordprocessing document.
/// This class provides a property for specifying the layout type, enabling control over table rendering and structure (such as fixed or auto layout).
/// </summary>
[OpenXmlType(typeof(DXW.TableLayout))]
[XmlRoot("TableLayout", Namespace = "DocumentModel.Wordprocessing")]
public partial class TableLayout : ModelElement<DXW.TableLayout>
{
 /// <summary>
 /// Table layout setting, specifying the type of layout algorithm used for the table.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableLayout.Type))]
 public TableLayoutType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private TableLayoutType? _Type;
}