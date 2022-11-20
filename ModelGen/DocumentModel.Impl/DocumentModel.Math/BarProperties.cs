namespace DocumentModel.Math;

/// <summary>
/// Bar Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IPosition))]
public class BarProperties: IBarProperties
{
  /// <summary>
  /// Position (Bar).
  /// </summary>
  public DocumentModel.Math.IPosition? Position
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
