namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public class ColorsType
{
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public ColorApplicationMethodKind? Method
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public HueDirectionKind? HueDirection
  {
    get;
    set;
  }
  
}
