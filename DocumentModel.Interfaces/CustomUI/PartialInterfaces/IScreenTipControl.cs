namespace DocumentModel;

/// <summary>
/// Defines members for specifying a screentip to be displayed for a control, either as a static string or via a callback function.
/// </summary>
/// <remarks>Implementations of this interface allow controls to provide contextual help or descriptions to users
/// through screentips. The screentip can be set directly or determined dynamically at runtime using a callback. Only
/// one method of specifying the screentip should be used at a time; if neither is set, the control's label may be used
/// as the screentip, or no screentip may be shown, depending on application behavior.</remarks>
public interface IScreenTipControl
{  
  /// <summary>
  ///   Specifies a string to be shown as the screentip for this control.
  ///
  ///  The Screentip and GetScreentip attributes are mutually exclusive.
  ///  If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the screentip of this control.
  /// 
  ///   The GetScreentip and Screentip attributes are mutually exclusive.
  ///   If neither attribute is specified, the application SHOULD display the label of the control as the screentip or display no screentip at all.
  /// </summary>
  public string? GetScreentip { get; set; }

}