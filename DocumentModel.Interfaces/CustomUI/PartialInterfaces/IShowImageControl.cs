namespace DocumentModel;

/// <summary>
/// Defines members for a control that can display an icon, allowing configuration of whether the icon is shown directly
/// or via a callback function.
/// </summary>
/// <remarks>Implementations should ensure that the ShowImage and GetShowImage properties are mutually exclusive.
/// If neither property is set, the control should display its icon by default. Use ShowImage to explicitly specify icon
/// visibility, or GetShowImage to provide the name of a callback that determines icon visibility dynamically.</remarks>
public interface IShowImageControl
{

  /// <summary>
  ///   Specifies whether this control displays an icon.
  ///   The ShowImage and GetShowImage attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon.
  /// </summary>
  public bool? ShowImage { get; set; }

  /// <summary>
  ///   Specifies the name of a callback function to be called to determine whether the application SHOULD display the icon of this control.
  ///   
  ///   The ShowImage and GetShowImage attributes are mutually exclusive. If neither attribute is specified, the control SHOULD display its icon.
  /// </summary>
  public string? GetShowImage { get; set; }
}