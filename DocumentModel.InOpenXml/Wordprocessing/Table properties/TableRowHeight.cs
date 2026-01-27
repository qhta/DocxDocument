namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the height of the current table row within the current table.
/// This height is used to determine the resulting height of the table row, which can be absolute or relative depending on its attribute values.
/// </summary>
[OpenXmlType(typeof(DXW.TableRowHeight))]
public partial class TableRowHeight : ModelElement<DXW.TableRowHeight>
{
 /// <summary>
 /// Table row height value, specifying the height in twips.
 /// </summary>
 public Twips Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

 private Twips _Value;
 /// <summary>
 /// Table row height type, specifying whether the height is at least, exactly, or auto.
 /// </summary>
 public HeightRuleKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private HeightRuleKind? _Type;
}