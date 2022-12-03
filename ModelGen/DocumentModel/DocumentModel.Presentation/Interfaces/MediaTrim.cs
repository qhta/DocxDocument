namespace DocumentModel.Presentation;

/// <summary>
/// Defines the MediaTrim Class.
/// </summary>
public interface MediaTrim // : System.Boolean
{
  /// <summary>
  /// st, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Start { get ; set; }
  
  /// <summary>
  /// end, this property is only available in Office 2010 and later.
  /// </summary>
  public String? End { get ; set; }
  
}
