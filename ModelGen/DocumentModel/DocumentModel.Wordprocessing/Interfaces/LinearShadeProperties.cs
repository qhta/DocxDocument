namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LinearShadeProperties Class.
/// </summary>
public interface LinearShadeProperties
{
  /// <summary>
  /// scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Scaled { get ; set; }
  
}
