namespace DocumentModel.Drawings.ChartsStyle;

/// <summary>
///   Defines the StyleReference Class.
/// </summary>
public class StyleReference: ModelElement
{
  /// <summary>
  ///   idx, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? Index { get; set; }
  /// <summary>
  ///   mods, this property is only available in Office 2013 and later.
  /// </summary>
  public ListOf<String>? Modifiers { get; set; }
}