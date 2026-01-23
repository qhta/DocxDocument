using DocumentModel.Vml;

namespace DocumentModel.Wordprocessing.Vml;
/// <summary>
/// Represents the default properties for VML objects in the header and footer of a WordprocessingML document.
/// This class provides properties for default shape properties and layout, enabling consistent formatting and positioning of VML shapes in document headers and footers.
/// </summary>
public partial class HeaderShapeDefaults : ModelElement<DXW.HeaderShapeDefaults>
{
  /// <summary>
  /// Default shape properties for VML shapes in the header and footer.
  /// </summary>
  [OpenXmlElement(typeof(DXW.HeaderShapeDefaults))]
  public ShapeDefaults? ShapeDefaults { get => _ShapeDefaults; set => UpdateField(ref _ShapeDefaults, value, nameof(ShapeDefaults)); }

  private ShapeDefaults? _ShapeDefaults;
  /// <summary>
  /// Default shape layout for VML shapes in the header and footer.
  /// </summary>
  [OpenXmlElement(typeof(DXW.HeaderShapeDefaults))]
  public ShapeLayout? ShapeLayout { get => _ShapeLayout; set => UpdateField(ref _ShapeLayout, value, nameof(ShapeLayout)); }

  private ShapeLayout? _ShapeLayout;
}