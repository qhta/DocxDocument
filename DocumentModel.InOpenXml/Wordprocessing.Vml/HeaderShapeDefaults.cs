using DocumentModel.Vml;
namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Represents the default properties for VML objects in the header and footer of a WordprocessingML document.
/// This interface provides properties for default shape properties and layout, enabling consistent formatting and positioning of VML shapes in document headers and footers.
/// </summary>
public interface HeaderShapeDefaults
{
  
  /// <summary>
  /// Default shape properties for VML shapes in the header and footer.
  /// </summary>
  public ShapeDefaults? ShapeDefaults { get; set; }
  
  /// <summary>
  /// Default shape layout for VML shapes in the header and footer.
  /// </summary>
  public ShapeLayout? ShapeLayout { get; set; }
}