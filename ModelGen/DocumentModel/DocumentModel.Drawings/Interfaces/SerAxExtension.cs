namespace DocumentModel.Drawings;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public interface SerAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NumberingFormat1? NumberingFormat { get ; set; }
  
}
