namespace DocumentModel.Drawings;
/// <summary>
///   Represents an extension for hyperlink formatting in a drawing object, specifying additional hyperlink properties such as UriString and color.
/// </summary>
[OpenXmlType(typeof(DXD.HyperlinkExtension))]
[DataContract]
[XmlRoot("HyperlinkExtension", Namespace = "DocumentModel.Drawings")]
public partial class HyperlinkExtension : ModelElement<DXD.HyperlinkExtension>
{
  /// <summary>
  ///   Color type for the hyperlink.
  /// </summary>
  public HyperlinkColor? HyperlinkColor { get => _HyperlinkColor; set => UpdateField(ref _HyperlinkColor, value, nameof(HyperlinkColor)); }
  private HyperlinkColor? _HyperlinkColor;
}