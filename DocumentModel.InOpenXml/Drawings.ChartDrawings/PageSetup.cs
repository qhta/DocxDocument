using DocumentModel.Drawings.Charts;

namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the PageSetup Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.PageSetup))]
[XmlRoot("PageSetup", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class PageSetup : ModelElement<DXO16DCD.PageSetup>
{
 /// <summary>
 /// Specifies the paper size.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.PaperSize))]
 public UInt32? PaperSize { get => _PaperSize; set => UpdateField(ref _PaperSize, value, nameof(PaperSize)); }
 private UInt32? _PaperSize;

 /// <summary>
 /// Specifies the first page number.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.FirstPageNumber))]
 public UInt32? FirstPageNumber { get => _FirstPageNumber; set => UpdateField(ref _FirstPageNumber, value, nameof(FirstPageNumber)); }
 private UInt32? _FirstPageNumber;

 /// <summary>
 /// Specifies the orientation.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.Orientation))]
 public PageOrientation? Orientation { get => _Orientation; set => UpdateField(ref _Orientation, value, nameof(Orientation)); }
 private PageOrientation? _Orientation;

 /// <summary>
 /// Specifies the black and white.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.BlackAndWhite))]
 public bool? BlackAndWhite { get => _BlackAndWhite; set => UpdateField(ref _BlackAndWhite, value, nameof(BlackAndWhite)); }
 private bool? _BlackAndWhite;

 /// <summary>
 /// Specifies the draft.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.Draft))]
 public bool? Draft { get => _Draft; set => UpdateField(ref _Draft, value, nameof(Draft)); }
 private bool? _Draft;

 /// <summary>
 /// Specifies the use first page number.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.UseFirstPageNumber))]
 public bool? UseFirstPageNumber { get => _UseFirstPageNumber; set => UpdateField(ref _UseFirstPageNumber, value, nameof(UseFirstPageNumber)); }
 private bool? _UseFirstPageNumber;

 /// <summary>
 /// Specifies the horizontal dpi.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.HorizontalDpi))]
 public Int32? HorizontalDpi { get => _HorizontalDpi; set => UpdateField(ref _HorizontalDpi, value, nameof(HorizontalDpi)); }
 private Int32? _HorizontalDpi;

 /// <summary>
 /// Specifies the vertical dpi.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.VerticalDpi))]
 public Int32? VerticalDpi { get => _VerticalDpi; set => UpdateField(ref _VerticalDpi, value, nameof(VerticalDpi)); }
 private Int32? _VerticalDpi;

 /// <summary>
 /// Specifies the copies.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PageSetup.Copies))]
 public UInt32? Copies { get => _Copies; set => UpdateField(ref _Copies, value, nameof(Copies)); }
 private UInt32? _Copies;
}