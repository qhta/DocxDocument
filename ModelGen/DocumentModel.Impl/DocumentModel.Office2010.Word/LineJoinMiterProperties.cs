namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public class LineJoinMiterProperties: ILineJoinMiterProperties
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Limit
  {
    get;
    set;
  }
  
}
