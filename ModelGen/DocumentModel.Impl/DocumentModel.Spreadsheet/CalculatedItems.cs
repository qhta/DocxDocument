namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedItems Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.ICalculatedItem))]
public class CalculatedItems: ICalculatedItems
{
  /// <summary>
  /// Calculated Item Formula Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
