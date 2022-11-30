namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldsUsage Class.
/// </summary>
public interface IFieldsUsage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public System.UInt32? Count { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IFieldUsage>? FieldUsages { get ; set; }
  
}
