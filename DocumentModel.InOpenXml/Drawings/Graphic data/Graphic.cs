namespace DocumentModel.Drawings;

/// <summary>
///   Represents a graphic object, containing graphic data.
/// </summary>
public class Graphic: ModelElement<DXD.Graphic>
{
  /// <summary>
  ///   Data associated with the graphic object.
  /// </summary>
  public GraphicData? GraphicData { get; set; }
}