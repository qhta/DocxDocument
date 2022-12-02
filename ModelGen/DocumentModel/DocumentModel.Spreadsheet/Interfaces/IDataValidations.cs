namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataValidations Class.
/// </summary>
public interface IDataValidations // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// disablePrompts, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? DisablePrompts { get ; set; }
  
  /// <summary>
  /// xWindow, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? XWindow { get ; set; }
  
  /// <summary>
  /// yWindow, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? YWindow { get ; set; }
  
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IDataValidation>? DataValidations { get ; set; }
  
}
