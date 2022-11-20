namespace DocumentModel.Spreadsheet;

/// <summary>
/// Chart Sheet Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ITabColor))]
public class ChartSheetProperties: IChartSheetProperties
{
  /// <summary>
  /// Published
  /// </summary>
  public bool? Published
  {
    get;
    set;
  }
  
  /// <summary>
  /// Code Name
  /// </summary>
  public string? CodeName
  {
    get;
    set;
  }
  
  /// <summary>
  /// TabColor.
  /// </summary>
  public ITabColor? TabColor
  {
    get;
    set;
  }
  
}
