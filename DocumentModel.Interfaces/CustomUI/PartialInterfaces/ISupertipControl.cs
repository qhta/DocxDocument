namespace DocumentModel;

/// <summary>
/// Defines members for specifying a supertip—an extended tooltip—for a user interface control. Implementations allow
/// setting a static supertip or providing a callback to determine the supertip dynamically.
/// </summary>
/// <remarks>The Supertip and GetSupertip properties are mutually exclusive. If neither property is set, no
/// supertip is displayed for the control. Implementers should ensure that only one of these properties is specified at
/// a time to avoid conflicts.</remarks>
public interface ISupertipControl
{
  /// <summary>
  ///   Specifies a string to be shown as the supertip of the control.
  ///
  ///  The Supertip and GetSupertip attributes are mutually exclusive. If neither attribute is specified no supertip for this control SHOULD be shown.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine the supertip of this control.
  /// 
  ///   The GetSupertip and Supertip attributes are mutually exclusive. If neither attribute is specified, no supertip for this control SHOULD be shown.
  /// </summary>
  public string? GetSupertip { get; set; }

}