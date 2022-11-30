namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataValidations Class.
/// </summary>
public interface IDataValidations // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Disable Prompts
  /// </summary>
  public System.Boolean? DisablePrompts { get ; set; }
  
  /// <summary>
  /// Top Left Corner (X Coodrinate)
  /// </summary>
  public System.UInt32? XWindow { get ; set; }
  
  /// <summary>
  /// Top Left Corner (Y Coordinate)
  /// </summary>
  public System.UInt32? YWindow { get ; set; }
  
  /// <summary>
  /// Data Validation Item Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IDataValidation>? DataValidations { get ; set; }
  
}
