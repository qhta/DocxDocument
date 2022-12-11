namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public interface ValAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NumberingFormat? NumberingFormat { get ; set; }
  
}
