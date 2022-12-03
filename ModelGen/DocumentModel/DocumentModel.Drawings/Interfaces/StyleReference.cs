namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public interface StyleReference // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index { get ; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public List<String>? Modifiers { get ; set; }
  
}
