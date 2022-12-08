namespace DocumentModel.Wordprocessing;

/// <summary>
/// Data About Single Data Source Record.
/// </summary>
public class RecipientDataImpl: ModelElementImpl, RecipientData
{
  public DocumentFormat.OpenXml.Wordprocessing.RecipientData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RecipientData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Record Is Included in Mail Merge.
  /// </summary>
  public Boolean? Active
  {
    get;
    set;
  }
  
  /// <summary>
  /// Index of Column Containing Unique Values for Record.
  /// </summary>
  public UInt32? ColumnIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Unique Value for Record.
  /// </summary>
  public DocumentModel.Base64BinaryValue? UniqueTag
  {
    get;
    set;
  }
  
}
