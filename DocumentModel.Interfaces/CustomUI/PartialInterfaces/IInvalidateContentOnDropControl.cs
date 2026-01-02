namespace DocumentModel;

/// <summary>
/// Interface for controls that can invalidate their contents on drop-down.
/// </summary>
public interface IInvalidateContentOnDropControl
{
  /// <summary>
  ///   Specifies whether this control invalidates its contents and re-queries for them when the user opens its drop-down menu.
  /// 
  ///   If this attribute is omitted, its value SHOULD default to "false".
  /// </summary>
  public bool? InvalidateContentOnDrop { get; set; }
}