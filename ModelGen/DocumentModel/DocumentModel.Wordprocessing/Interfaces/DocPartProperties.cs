namespace DocumentModel.Wordprocessing;

/// <summary>
/// Glossary Document Entry Properties.
/// </summary>
public interface DocPartProperties
{
  /// <summary>
  /// Entry Name.
  /// </summary>
  public DocPartName? DocPartName { get ; set; }
  
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
  
}
