namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public interface IDocPartProperties // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  public IDocPartName? DocPartName { get ; set; }
  
  /// <summary>
  /// Associated Paragraph Style Name.
  /// </summary>
  public IStyleId? StyleId { get ; set; }
  
  /// <summary>
  /// Entry Categorization.
  /// </summary>
  public ICategory? Category { get ; set; }
  
  /// <summary>
  /// Entry Types.
  /// </summary>
  public IDocPartTypes? DocPartTypes { get ; set; }
  
  /// <summary>
  /// Entry Insertion Behaviors.
  /// </summary>
  public IBehaviors? Behaviors { get ; set; }
  
  /// <summary>
  /// Description for Entry.
  /// </summary>
  public IDescription? Description { get ; set; }
  
  /// <summary>
  /// Entry ID.
  /// </summary>
  public IStringValue? DocPartId { get ; set; }
  
}
