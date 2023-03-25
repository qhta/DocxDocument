namespace DocumentModel.Drawings;

/// <summary>
///   Graphic Object.
/// </summary>
public class Graphic: ModelElement
{
  /// <summary>
  ///   Graphic Object Data.
  /// </summary>
  [XmlContentElement] public GraphicData? GraphicData { get; set; }
}