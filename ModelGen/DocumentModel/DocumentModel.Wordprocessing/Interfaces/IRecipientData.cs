namespace DocumentModel.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IUniqueTag))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IActive))]
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IColumnIndex))]
public interface IRecipientData // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
  public IUniqueTag? UniqueTag { get ; set; }
  
}
