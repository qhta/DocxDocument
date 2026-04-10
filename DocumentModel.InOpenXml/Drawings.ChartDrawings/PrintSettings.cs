namespace DocumentModel.Drawings.ChartDrawings;
/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
[OpenXmlType(typeof(DXO16DCD.PrintSettings))]
[XmlRoot("PrintSettings", Namespace = "DocumentModel.Drawings.ChartDrawings")]
public class PrintSettings : ModelElement<DXO16DCD.PrintSettings>
{
 /// <summary>
 /// Specifies the header footer.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PrintSettings.HeaderFooter))]
 public HeaderFooter? HeaderFooter { get => _HeaderFooter; set => UpdateField(ref _HeaderFooter, value, nameof(HeaderFooter)); }

 private HeaderFooter? _HeaderFooter;
 /// <summary>
 /// Specifies the page margins.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PrintSettings.PageMargins))]
 public PageMargins? PageMargins { get => _PageMargins; set => UpdateField(ref _PageMargins, value, nameof(PageMargins)); }

 private PageMargins? _PageMargins;
 /// <summary>
 /// Specifies the page setup.
 /// </summary>
 [OpenXmlProperty(nameof(DXO16DCD.PrintSettings.PageSetup))]
 public PageSetup? PageSetup { get => _PageSetup; set => UpdateField(ref _PageSetup, value, nameof(PageSetup)); }

 private PageSetup? _PageSetup;
}