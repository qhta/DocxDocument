namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the page size settings for a section in a Wordprocessing document.
/// This class provides properties for page width, height, orientation, printer paper code, and paper size, enabling advanced configuration of page layout and printing options.
/// </summary>
[OpenXmlType(typeof(DXW.PageSize))]
public partial class PageSize : ModelElement<DXW.PageSize>, ISectionPropertiesContent
{
 /// <summary>
 /// Page width, specified in twips.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageSize.Width))]
 public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

 private Twips? _Width;
 /// <summary>
 /// Page height, specified in twips.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageSize.Height))]
 public Twips? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }

 private Twips? _Height;
 /// <summary>
 /// Page orientation, such as portrait or landscape.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PageSize.Orient))]
 public PageOrientationKind? Orient { get => _Orient; set => UpdateField(ref _Orient, value, nameof(Orient)); }

 private PageOrientationKind? _Orient;
  /// <summary>
  /// Printer paper size, mapped from the printer paper code.
  /// </summary>
  [NotMapped]
 public PaperSize? PaperSize { get => _PaperSize; set => UpdateField(ref _PaperSize, value, nameof(PaperSize)); }

 private PaperSize? _PaperSize;
}