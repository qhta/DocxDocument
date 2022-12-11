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
  
  public NumberingFormat? NumberingFormat { get ; set; }
  
}
