namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public interface DateAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.Charts.NumberingFormat3? NumberingFormat { get ; set; }
  
}
