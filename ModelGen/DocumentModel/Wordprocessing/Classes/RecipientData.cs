namespace DocumentModel.Wordprocessing;


/// <summary>
///   Data About Single Data Source Record.
/// </summary>
public partial class RecipientData
{
  
  /// <summary>
  ///   Record Is Included in Mail Merge.
  /// </summary>
  public DocumentModel.Wordprocessing.Active? Active { get; set; }
  
  
  /// <summary>
  ///   Index of Column Containing Unique Values for Record.
  /// </summary>
  public DocumentModel.Wordprocessing.ColumnIndex? ColumnIndex { get; set; }
  
  
  /// <summary>
  ///   Unique Value for Record.
  /// </summary>
  public DM.Base64Binary? UniqueTag { get; set; }
  
}
