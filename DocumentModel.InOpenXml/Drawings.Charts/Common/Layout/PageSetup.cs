namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Page Setup.
/// </summary>
[OpenXmlType(typeof(DXDC.PageSetup))]
[DataContract]
[XmlRoot("PageSetup", Namespace = "DocumentModel.Drawings.Charts")]
public partial class PageSetup : ModelElement<DXDC.PageSetup>
{
 /// <summary>
 ///   Page Size
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.PaperSize))]
 public UInt32? PaperSize { get => _PaperSize; set => UpdateField(ref _PaperSize, value, nameof(PaperSize)); }
 private UInt32? _PaperSize;

 /// <summary>
 ///   First Page Number
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.FirstPageNumber))]
 public Int32? FirstPageNumber { get => _FirstPageNumber; set => UpdateField(ref _FirstPageNumber, value, nameof(FirstPageNumber)); }
 private Int32? _FirstPageNumber;

 /// <summary>
 ///   Orientation
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.Orientation))]
 public PageSetupOrientation? Orientation { get => _Orientation; set => UpdateField(ref _Orientation, value, nameof(Orientation)); }
 private PageSetupOrientation? _Orientation;

 /// <summary>
 ///   Black and White
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.BlackAndWhite))]
 public bool? BlackAndWhite { get => _BlackAndWhite; set => UpdateField(ref _BlackAndWhite, value, nameof(BlackAndWhite)); }
 private bool? _BlackAndWhite;

 /// <summary>
 ///   Draft
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.Draft))]
 public bool? Draft { get => _Draft; set => UpdateField(ref _Draft, value, nameof(Draft)); }
 private bool? _Draft;

 /// <summary>
 ///   Use First Page Number
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.UseFirstPageNumber))]
 public bool? UseFirstPageNumber { get => _UseFirstPageNumber; set => UpdateField(ref _UseFirstPageNumber, value, nameof(UseFirstPageNumber)); }
 private bool? _UseFirstPageNumber;

 /// <summary>
 ///   Horizontal DPI
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.HorizontalDpi))]
 public Int32? HorizontalDpi { get => _HorizontalDpi; set => UpdateField(ref _HorizontalDpi, value, nameof(HorizontalDpi)); }
 private Int32? _HorizontalDpi;

 /// <summary>
 ///   Vertical DPI
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.VerticalDpi))]
 public Int32? VerticalDpi { get => _VerticalDpi; set => UpdateField(ref _VerticalDpi, value, nameof(VerticalDpi)); }
 private Int32? _VerticalDpi;

 /// <summary>
 ///   Copies
 /// </summary>
 [OpenXmlProperty(nameof(DXDC.PageSetup.Copies))]
 public UInt32? Copies { get => _Copies; set => UpdateField(ref _Copies, value, nameof(Copies)); }
 private UInt32? _Copies;
}