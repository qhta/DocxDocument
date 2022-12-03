namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Table Class.
/// </summary>
public interface Table // : System.Boolean
{
  /// <summary>
  /// altText, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AltText { get ; set; }
  
  /// <summary>
  /// altTextSummary, this property is only available in Office 2010 and later.
  /// </summary>
  public String? AltTextSummary { get ; set; }
  
}
