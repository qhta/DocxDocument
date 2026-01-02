namespace DocumentModel;

/// <summary>
/// Defines members for a control that supports specifying or retrieving a suggested KeyTip, which is a keyboard
/// shortcut label displayed in the user interface.
/// </summary>
/// <remarks>Implementations allow a control to provide a KeyTip either directly via the Keytip property or
/// dynamically via a callback specified by GetKeytip. If neither property is set, the application should generate a
/// KeyTip automatically. The Keytip and GetKeytip properties are mutually exclusive; only one should be specified for a
/// given control.</remarks>
public interface IKeyTipControl
{
  /// <summary>
  ///   Specifies a string to be used as the suggested KeyTip for this control.
  /// 
  ///   The GetKeytip and Keytip attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the suggested KeyTip of this control.
  /// 
  ///   The GetKeytip and Keytip attributes are mutually exclusive. If neither attribute is specified, the application SHOULD generate a KeyTip for the control automatically.
  /// </summary>
  public string? GetKeytip { get; set; }


}