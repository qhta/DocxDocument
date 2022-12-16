namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public interface StyleReference
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<System.String>? Modifiers { get ; set; }
  
}
