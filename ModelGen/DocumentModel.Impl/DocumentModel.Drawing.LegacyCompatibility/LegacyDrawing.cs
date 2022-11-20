namespace DocumentModel.Drawing.LegacyCompatibility;

/// <summary>
/// Legacy Drawing Object.
/// </summary>
public class LegacyDrawing: ILegacyDrawing
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public string? ShapeId
  {
    get;
    set;
  }
  
}
