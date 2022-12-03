namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaBookmark Class.
/// </summary>
public interface MediaBookmark // : System.Boolean
{
  /// <summary>
  /// name, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Time { get ; set; }
  
}
