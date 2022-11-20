namespace DocumentModel.Office2019.Excel.RichData2;

/// <summary>
/// Defines the RichStylePropertyValue Class.
/// </summary>
public class RichStylePropertyValue: IRichStylePropertyValue
{
  /// <summary>
  /// i, this property is only available in Office 2019 and later.
  /// </summary>
  public uint? I
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
