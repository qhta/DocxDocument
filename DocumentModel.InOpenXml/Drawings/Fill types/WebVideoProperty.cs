namespace DocumentModel.Drawings;
/// <summary>
/// Represents properties for an embedded web video, including HTML markup and display dimensions.
/// </summary>
[OpenXmlType(typeof(DXO13WD.WebVideoProperty))]
[XmlRoot("WebVideoProperty", Namespace = "DocumentModel.Drawings")]
public partial class WebVideoProperty : ModelElement<DXO13WD.WebVideoProperty>
{
 /// <summary>
 /// Gets or sets the embedded HTML markup used to render the web video.
 /// </summary>
 public string? EmbeddedHtml { get => _EmbeddedHtml; set => UpdateField(ref _EmbeddedHtml, value, nameof(EmbeddedHtml)); }
 private string? _EmbeddedHtml;

 /// <summary>
 /// Gets or sets the height of the web video display area, in pixels.
 /// </summary>
 public UInt32? Height { get => _Height; set => UpdateField(ref _Height, value, nameof(Height)); }
 private UInt32? _Height;

 /// <summary>
 /// Gets or sets the width of the web video display area, in pixels.
 /// </summary>
 public UInt32? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }
 private UInt32? _Width;
}