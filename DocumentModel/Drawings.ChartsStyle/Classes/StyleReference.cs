namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public partial class StyleReference
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index { get; set; }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.ListOf<System.String>? Modifiers { get; set; }
  
}
