namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public interface IDocPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocPartName? DocPartName { get ; set; }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public System.String? StyleId { get ; set; }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public DocumentModel.Wordprocessing.ICategory? Category { get ; set; }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public DocumentModel.Wordprocessing.IDocPartTypes? DocPartTypes { get ; set; }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public DocumentModel.Wordprocessing.IBehaviors? Behaviors { get ; set; }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public System.String? Description { get ; set; }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public System.String? DocPartId { get ; set; }
  
}
