namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a break element placed at the current location in the run content of a WordprocessingML document.
/// A break is a special character used to override normal line breaking, with behavior determined by its type and clear attribute values. This enables advanced control over text flow, line, and page breaks within document content.
/// </summary>
[OpenXmlType(typeof(DXW.Break))]
[DataContract]
[XmlRoot("Break", Namespace = "DocumentModel.Wordprocessing")]
public partial class Break : ModelElement<DXW.Break>, IRunContent
{
 /// <summary>
 /// Type of break to insert, specifying the kind of break (e.g., line, page, column, text wrapping).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Break.Type))]
 public BreakType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private BreakType? _Type;

 /// <summary>
 /// Restart location for text wrapping break, specifying where text should resume after the break (e.g., left, right, all).
 /// </summary>
 [OpenXmlProperty(nameof(DXW.Break.Clear))]
 public BreakTextRestartLocation? Clear { get => _Clear; set => UpdateField(ref _Clear, value, nameof(Clear)); }
 private BreakTextRestartLocation? _Clear;
}