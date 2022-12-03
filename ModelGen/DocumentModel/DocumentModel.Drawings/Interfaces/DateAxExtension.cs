namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DateAxExtension Class.
/// </summary>
public interface DateAxExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NumberingFormat? NumberingFormat { get ; set; }
  
}
