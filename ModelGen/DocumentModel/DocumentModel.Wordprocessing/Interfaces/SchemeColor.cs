namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SchemeColor Class.
/// </summary>
public interface SchemeColor
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public SchemeColorKind? Val { get ; set; }
  
}
