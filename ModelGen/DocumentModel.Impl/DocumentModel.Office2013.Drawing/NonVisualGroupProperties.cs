namespace DocumentModel.Office2013.Drawing;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public class NonVisualGroupProperties: INonVisualGroupProperties
{
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? IsLegacyGroup
  {
    get;
    set;
  }
  
}
