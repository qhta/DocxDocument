namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public partial interface LinearShadeProperties
{
  /// <summary>
  /// ang, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Angle { get; set; }
  
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffKind? Scaled { get; set; }
  
}
