namespace DocumentModel.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
public interface IRecipientData // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Record Is Included in Mail Merge.
  /// </summary>
  public IActive? Active { get ; set; }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  public IColumnIndex? ColumnIndex { get ; set; }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  public IBase64BinaryValue? UniqueTag { get ; set; }
  
}
