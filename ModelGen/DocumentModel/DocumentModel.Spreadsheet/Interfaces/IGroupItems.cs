namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Group Items.
/// </summary>
public interface IGroupItems // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Items Created Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public DocumentModel.Spreadsheet.IMissingItem? MissingItem { get ; set; }
  
  public DocumentModel.Spreadsheet.INumberItem? NumberItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IBooleanItem? BooleanItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IErrorItem? ErrorItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IStringItem? StringItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IDateTimeItem? DateTimeItem { get ; set; }
  
}
