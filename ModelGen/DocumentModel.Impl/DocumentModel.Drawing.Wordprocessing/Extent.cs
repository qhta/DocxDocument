namespace DocumentModel.Drawing.Wordprocessing;

/// <summary>
/// Inline Drawing Object Extents.
/// </summary>
public class Extent: IExtent
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public long? Cx
  {
    get;
    set;
  }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public long? Cy
  {
    get;
    set;
  }
  
}
