namespace DocumentModel.Wordprocessing;
/// <summary>
/// Specifies the background for every page of the document containing the background element in a WordprocessingML document.
/// The document background is the image or fill for the entire page surface, appearing behind all other document content.
/// </summary>
[OpenXmlType(typeof(DXW.DocumentBackground))]
[XmlRoot("DocumentBackground", Namespace = "DocumentModel.Wordprocessing")]
public partial class DocumentBackground : ModelElement<DXW.DocumentBackground>
{
 /// <summary>
 /// Color for the background of the document, specifying the fill color applied to all pages.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentBackground.Color))]
 public Color? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }
 private Color? _Color;

 /// <summary>
 /// Background element, specifying additional background properties such as images or patterns.
 /// </summary>
 [OpenXmlProperty(nameof(DXW.DocumentBackground.Background))]
 public DMV.Background? Background { get => _Background; set => UpdateField(ref _Background, value, nameof(Background)); }
 private DMV.Background? _Background;
}