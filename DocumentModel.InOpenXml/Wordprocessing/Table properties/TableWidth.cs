namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the TableWidth class. Its Value can be absolute (in twips) or relative (in fiftieth of percent), or "auto" or "nil".
/// The type of the Value is determined with the Type property.
/// This class is used in multiple measures according to table horizontal dimension.
/// </summary>
[OpenXmlType(typeof(DXW.TableWidth))]
public partial class TableWidth : ModelElement<DXW.TableWidth>
{
 /// <summary>
 /// Table width value, which can be absolute (in twips) or relative (in fiftieth of percent).
 /// </summary>
 [OpenXmlElement(typeof(DXW.TableWidth))]
 public Int64 Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

 private Int64 _Value;
 /// <summary>
 /// Table width type, determining whether the value is absolute, relative, "auto", or "nil".
 /// </summary>
 [OpenXmlProperty(nameof(DXW.TableWidth.Type))]
 [OpenXmlElement(typeof(DXW.TableWidth))]
 public TableWidthUnitType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

 private TableWidthUnitType? _Type;
}