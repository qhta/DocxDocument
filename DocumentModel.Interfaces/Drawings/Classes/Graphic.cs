namespace DocumentModel.Drawings;
/// <summary>
///   Graphic Object.
/// </summary>
public interface Graphic: IModelElement
{
  /// <summary>
  ///   Graphic Object Data.
  /// </summary>
  public GraphicData? GraphicData { get; set; }
}