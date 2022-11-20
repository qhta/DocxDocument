namespace DocumentModel.Drawing;

/// <summary>
/// Graphic Object.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IGraphicData))]
public class Graphic: IGraphic
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public IGraphicData? GraphicData
  {
    get;
    set;
  }
  
}
