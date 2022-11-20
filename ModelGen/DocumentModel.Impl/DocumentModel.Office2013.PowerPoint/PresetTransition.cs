namespace DocumentModel.Office2013.PowerPoint;

/// <summary>
/// Defines the PresetTransition Class.
/// </summary>
public class PresetTransition: IPresetTransition
{
  /// <summary>
  /// prst, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Preset
  {
    get;
    set;
  }
  
  /// <summary>
  /// invX, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? InvX
  {
    get;
    set;
  }
  
  /// <summary>
  /// invY, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? InvY
  {
    get;
    set;
  }
  
}
