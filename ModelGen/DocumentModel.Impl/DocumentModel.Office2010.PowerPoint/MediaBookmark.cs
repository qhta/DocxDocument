namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the MediaBookmark Class.
/// </summary>
public class MediaBookmark: IMediaBookmark
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Time
  {
    get;
    set;
  }
  
}
