namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public interface LineJoinMiterProperties // : System.Boolean
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Limit { get ; set; }
  
}
