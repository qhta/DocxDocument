namespace DocumentModel.Spreadsheet;

/// <summary>
/// Data Bar.
/// </summary>
public interface IDataBar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Minimum Length
  /// </summary>
  public System.UInt32? MinLength { get ; set; }
  
  /// <summary>
  /// Maximum Length
  /// </summary>
  public System.UInt32? MaxLength { get ; set; }
  
  /// <summary>
  /// Show Values
  /// </summary>
  public System.Boolean? ShowValue { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IConditionalFormatValueObject>? ConditionalFormatValueObjects { get ; set; }
  
  public DocumentModel.Spreadsheet.IColorType? Color { get ; set; }
  
}
