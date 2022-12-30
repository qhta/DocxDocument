namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public partial class DocPartProperties
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartName? DocPartName { get; set; }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public String? StyleId { get; set; }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public DocumentModel.Wordprocessing.Category? Category { get; set; }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public DocumentModel.Wordprocessing.DocPartTypes? DocPartTypes { get; set; }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public DocumentModel.Wordprocessing.Behaviors? Behaviors { get; set; }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public String? Description { get; set; }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public String? DocPartId { get; set; }
  
}
