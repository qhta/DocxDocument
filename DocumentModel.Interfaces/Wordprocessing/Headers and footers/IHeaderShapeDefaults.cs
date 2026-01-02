using DocumentModel.Vml;
namespace DocumentModel.Wordprocessing;
/// <summary>
///   Default Properties for VML Objects in Header and Footer.
/// </summary>
public interface IHeaderShapeDefaults: IModelElement
{
  /// <summary>
  /// Default Shape Properties for VML Shapes in Header and Footer.
  /// </summary>
  public DocumentModel.Vml.IShapeDefaults? ShapeDefaults { get; set; }
  /// <summary>
  /// Default Shape Layout for VML Shapes in Header and Footer.
  /// </summary>
  public ShapeLayout? ShapeLayout { get; set; }
}