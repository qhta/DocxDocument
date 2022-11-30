namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache Record.
/// </summary>
public interface IPivotCacheRecord // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public DocumentModel.Spreadsheet.IMissingItem? MissingItem { get ; set; }
  
  public DocumentModel.Spreadsheet.INumberItem? NumberItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IBooleanItem? BooleanItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IErrorItem? ErrorItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IStringItem? StringItem { get ; set; }
  
  public DocumentModel.Spreadsheet.IDateTimeItem? DateTimeItem { get ; set; }
  
  public System.UInt32? FieldItem { get ; set; }
  
}
