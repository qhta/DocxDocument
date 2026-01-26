using DocumentModel.Wordprocessing;

namespace DocumentModel.Vml;
/// <summary>
/// Represents a VML text box element with styling and content properties.
/// </summary>
[OpenXmlType(typeof(DXV.TextBox))]
public partial class TextBox : ModelElement<DXV.TextBox>
{
 /// <summary>
 /// Unique identifier for the text box.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.TextBox.Id))]
 [OpenXmlElement(typeof(DXV.TextBox))]
 public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

 private string? _Id;
 /// <summary>
 /// CSS-style string specifying shape styling properties for the text box.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.TextBox.Style))]
 [OpenXmlElement(typeof(DXV.TextBox))]
 public string? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

 private string? _Style;
 /// <summary>
 /// Inset margin values for the text box content.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.TextBox.Inset))]
 [OpenXmlElement(typeof(DXV.TextBox))]
 public string? Inset { get => _Inset; set => UpdateField(ref _Inset, value, nameof(Inset)); }

 private string? _Inset;
 /// <summary>
 /// Indicates whether single-click selection is enabled for the text box.
 /// </summary>
 [OpenXmlProperty(nameof(DXV.TextBox.SingleClick))]
 [OpenXmlElement(typeof(DXV.TextBox))]
 public bool? SingleClick { get => _SingleClick; set => UpdateField(ref _SingleClick, value, nameof(SingleClick)); }

 private bool? _SingleClick;
 /// <summary>
 /// Content of the text box, including paragraphs and runs.
 /// </summary>
 [OpenXmlElement(typeof(DXV.TextBox))]
 public TextBoxContent? TextBoxContent { get => _TextBoxContent; set => UpdateField(ref _TextBoxContent, value, nameof(TextBoxContent)); }

 private TextBoxContent? _TextBoxContent;
}