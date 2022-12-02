namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldsUsage Class.
/// </summary>
public interface IFieldsUsage // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<IFieldUsage>? FieldUsages { get ; set; }
  
}
