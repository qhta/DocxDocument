namespace DocumentModel;

/// <summary>
/// Defines members that control the visibility state of a user interface control.
/// </summary>
/// <remarks>Implement this interface to provide static or dynamic visibility behavior for a control. The
/// visibility can be set directly or determined at runtime using a callback function. The Visible and GetVisible
/// members are mutually exclusive; only one should be specified. If neither is set, the control defaults to being
/// visible.</remarks>
public interface IVisibleControl
{

  /// <summary>
  ///   Specifies the visibility state of the control.
  ///
  ///  The GetVisible and Visible attributes are mutually exclusive.If these attributes are omitted, the control SHOULD default to being visible.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///  Specifies the name of a callback function to be called to determine the visibility state of this control.
  /// 
  ///  The GetVisible and Visible attributes are mutually exclusive. If neither attribute is specified, the control SHOULD default to being visible.
  /// </summary>
  public string? GetVisible { get; set; }
}