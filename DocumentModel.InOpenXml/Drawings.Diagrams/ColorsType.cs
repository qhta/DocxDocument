namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///  Base class for color lists.
/// </summary>
/// <typeparam name="T">OpenXmlCompositeElement type.</typeparam>
public abstract class ColorsType<T>: ModelElementCollection<ColorType> where T: DX.OpenXmlCompositeElement
{
  /// <summary>
  /// Method of applying the color list to the shape.
  /// </summary>
  public ColorApplicationMethod? Method{ get; set; }

  /// <summary>
  /// Direction of hue adjustment for the color list.
  /// </summary>
  public HueDirection? HueDirection { get; set; }
}