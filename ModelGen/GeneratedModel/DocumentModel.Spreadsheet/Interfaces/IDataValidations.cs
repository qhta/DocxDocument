namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DataValidations Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDataValidation))]
public interface IDataValidations // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Disable Prompts
  /// </summary>
  public bool? DisablePrompts { get ; set; }
  
  /// <summary>
  /// Top Left Corner (X Coodrinate)
  /// </summary>
  public uint? XWindow { get ; set; }
  
  /// <summary>
  /// Top Left Corner (Y Coordinate)
  /// </summary>
  public uint? YWindow { get ; set; }
  
  /// <summary>
  /// Data Validation Item Count
  /// </summary>
  public uint? Count { get ; set; }
  
}
