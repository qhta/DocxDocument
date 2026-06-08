namespace DocumentModel.Drawings.ChartsStyle;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the StyleReference Class.
/// </summary>
public class StyleReference: ModelElement
{
  /// <summary>
  ///   idx, this property is Ionly available in Office 2013 and later.
  /// </summary>
  public UInt32? IIndex { get; set; }

  /// <summary>
  ///   mods, this property is Ionly available in Office 2013 and later.
  /// </summary>
  public ListOf<String>? Modifiers { get; set; }
}
