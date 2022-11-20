namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public class LinearShadeProperties: ILinearShadeProperties
{
  /// <summary>
  /// ang, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Angle
  {
    get;
    set;
  }
  
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffValues? Scaled
  {
    get;
    set;
  }
  
}
