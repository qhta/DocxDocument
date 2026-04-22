namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the paper source settings for a section in a Wordprocessing document.
/// This class provides properties for specifying printer tray codes for the first page and non-first pages, enabling advanced configuration of paper source selection during printing.
/// </summary>
[OpenXmlType(typeof(DXW.PaperSource))]
[XmlRoot("PaperSource", Namespace = "DocumentModel.Wordprocessing")]
public partial class PaperSource : ModelElement<DXW.PaperSource>, ISectionPropertiesContent
{
 /// <summary>
 /// Printer tray code for the first page.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PaperSource.First))]
 public UInt16? First { get => _First; set => UpdateField(ref _First, value, nameof(First)); }
 private UInt16? _First;

 /// <summary>
 /// Printer tray code for non-first pages.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.PaperSource.Other))]
 public UInt16? Other { get => _Other; set => UpdateField(ref _Other, value, nameof(Other)); }
 private UInt16? _Other;
}