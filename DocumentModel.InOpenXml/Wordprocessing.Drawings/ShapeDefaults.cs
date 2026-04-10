using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing.Drawings;
/// <summary>
/// Represents the default properties for VML (Vector Markup Language) objects in the main document of a Wordprocessing file.
/// This class provides access to child shape defaults and shape layout settings, enabling consistent formatting and layout for VML shapes throughout the document.
/// </summary>
[OpenXmlType(typeof(DXW.ShapeDefaults))]
[XmlRoot("ShapeDefaults", Namespace = "DocumentModel.Wordprocessing.Drawings")]
public partial class ShapeDefaults : ModelElement<DXW.ShapeDefaults>
{
 /// <summary>
 /// The default properties applied to child VML shapes, specifying baseline formatting and behavior for all contained shapes.
 /// </summary>
 public DocumentModel.Vml.ShapeDefaults? ChildShapeDefaults { get => _ChildShapeDefaults; set => UpdateField(ref _ChildShapeDefaults, value, nameof(ChildShapeDefaults)); }

 private DocumentModel.Vml.ShapeDefaults? _ChildShapeDefaults;
 /// <summary>
 /// The layout settings for shapes, controlling arrangement, positioning, and other layout-related properties for VML objects.
 /// </summary>
 public ShapeLayout? ShapeLayout { get => _ShapeLayout; set => UpdateField(ref _ShapeLayout, value, nameof(ShapeLayout)); }

 private ShapeLayout? _ShapeLayout;
}