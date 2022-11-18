namespace DocumentModel.Spreadsheet;

/// <summary>
/// Page Item.
/// </summary>
public interface IPageItem // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Page Item Name
  /// </summary>
  public string? Name { get ; set; }
  
}
