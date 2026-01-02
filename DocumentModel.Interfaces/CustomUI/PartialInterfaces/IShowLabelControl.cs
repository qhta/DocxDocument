namespace DocumentModel;

/// <summary>
/// Defines members that control whether a UI element displays its label, either directly or via a callback function.
/// </summary>
/// <remarks>Implementations should ensure that only one of ShowLabel or GetShowLabel is specified at a time, as
/// they are mutually exclusive. If neither is set, the control should default to showing its label. This interface is
/// typically used by UI components that support configurable label visibility.</remarks>
public interface IShowLabelControl
{

  /// <summary>
  ///   Specifies whether this control displays its label.
  /// 
  ///   The ShowLabel and GetShowLabel attributes are mutually exclusive.If neither attribute is specified, the control SHOULD default to showing its label.
  /// </summary>
  public bool? ShowLabel { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine whether the application SHOULD display the label of this control.
  /// 
  ///   The ShowLabel and GetShowLabel attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to showing its label.
  /// </summary>
  public string? GetShowLabel { get; set; }
}