namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StrDataExtension Class.
/// </summary>
public interface StrDataExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public Boolean? AutoGeneneratedCategories { get ; set; }
  
}
