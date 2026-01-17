namespace DocumentModel.Drawings;

/// <summary>
///   Represents the default shape definition, including visual properties, body properties, list style, and shape style.
/// </summary>
public class DefaultShapeDefinitionType : ModelElement<DXD.DefaultShapeDefinitionType>, IExtendableElement
{
  /// <summary>
  ///   Visual properties for the default shape.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   Body properties for the default shape.
  /// </summary>
  public BodyProperties? BodyProperties { get; set; }

  /// <summary>
  ///   List style for the default shape.
  /// </summary>
  public ListStyle? ListStyle { get; set; }

  /// <summary>
  ///   Shape style for the default shape.
  /// </summary>
  public ShapeStyle? ShapeStyle { get; set; }

  public IExtensionList? ExtensionList { get; set; }
}