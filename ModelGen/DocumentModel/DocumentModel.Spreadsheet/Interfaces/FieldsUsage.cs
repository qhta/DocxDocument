namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the FieldsUsage Class.
/// </summary>
public interface FieldsUsage // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Field Count
  /// </summary>
  public UInt32? Count { get ; set; }
  
  public Collection<FieldUsage>? FieldUsages { get ; set; }
  
}
