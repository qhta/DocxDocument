namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public interface DateAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NumberingFormat2? NumberingFormat { get ; set; }
  
}
