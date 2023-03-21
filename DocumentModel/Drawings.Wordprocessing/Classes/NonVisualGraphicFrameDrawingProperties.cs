namespace DocumentModel.Drawings.Wordprocessing;

/// <summary>
///   Defines the NonVisualGraphicFrameDrawingProperties Class.
/// </summary>
public class NonVisualGraphicFrameDrawingProperties: ModelElement
{
  /// <summary>
  ///   Graphic Frame Locks.
  /// </summary>
  [XmlContentElement] public GraphicFrameLocks? GraphicFrameLocks { get; set; }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [XmlContentElement] public ExtensionList? ExtensionList { get; set; }
}