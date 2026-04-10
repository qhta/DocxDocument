namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents settings for freezing the document layout in read mode for ink content in a Wordprocessing document.
/// This class provides properties for controlling page usage, virtual page dimensions, and font size scaling, enabling consistent rendering and layout preservation when displaying ink annotations or drawings.
/// </summary>
[OpenXmlType(typeof(DXW.ReadModeInkLockDown))]
[XmlRoot("ReadModeInkLockDown", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class ReadModeInkLockDown : ModelElement<DXW.ReadModeInkLockDown>
{
 /// <summary>
 /// Indicates whether actual pages are used instead of virtual pages for layout, affecting how ink content is rendered and paginated.
 /// </summary>
 public bool? UseActualPages { get => _UseActualPages; set => UpdateField(ref _UseActualPages, value, nameof(UseActualPages)); }

 private bool? _UseActualPages;
 /// <summary>
 /// The width of the virtual page, specified in units relevant to the document, used for layout calculations in read mode.
 /// </summary>
 public UInt32? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private UInt32? _Width;
 /// <summary>
 /// The height of the virtual page, specified in units relevant to the document, used for layout calculations in read mode.
 /// </summary>
 public UInt32? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

 private UInt32? _Height;
 /// <summary>
 /// The scaling factor for font size, specified as a string, used to adjust text size for consistent appearance in read mode.
 /// </summary>
 public string? FontSize { get => _FontSize; set => UpdateField(ref _FontSize, value, nameof(FontSize)); }

 private string? _FontSize;
}