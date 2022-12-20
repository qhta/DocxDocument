namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineJoinMiterProperties Class.
/// </summary>
public partial interface LineJoinMiterProperties
{
  /// <summary>
  /// lim, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Limit { get; set; }
  
}
