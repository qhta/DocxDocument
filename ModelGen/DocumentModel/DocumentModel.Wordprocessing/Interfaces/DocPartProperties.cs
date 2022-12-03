namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public interface DocPartProperties // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  public DocPartName? DocPartName { get ; set; }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public String? StyleId { get ; set; }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public Category? Category { get ; set; }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public DocPartTypes? DocPartTypes { get ; set; }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public Behaviors? Behaviors { get ; set; }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public String? Description { get ; set; }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public String? DocPartId { get ; set; }
  
}
