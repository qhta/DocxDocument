namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public class GraphicImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Graphic>, Graphic
{
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public GraphicData? GraphicData
  {
    get;
    set;
  }
  
}
