namespace DocumentModel.Drawing.Spreadsheet;

/// <summary>
/// Defines the Extent Class.
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
