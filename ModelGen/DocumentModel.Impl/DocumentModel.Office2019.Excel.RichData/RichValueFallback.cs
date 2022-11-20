namespace DocumentModel.Office2019.Excel.RichData;

/// <summary>
/// Defines the RichValueFallback Class.
/// </summary>
public class RichValueFallback: IRichValueFallback
{
  /// <summary>
  /// t, this property is only available in Office 2019 and later.
  /// </summary>
  public RichValueFallbackType? T
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
