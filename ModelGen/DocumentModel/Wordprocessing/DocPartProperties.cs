namespace DocumentModel.Wordprocessing;


/// <summary>
///   Glossary Document Entry Properties.
/// </summary>
public partial class DocPartProperties
{
  
  /// <summary>
  ///   Entry Name.
  /// </summary>
  public DMW.DocPartName? DocPartName { get; set; }
  
  
  /// <summary>
  ///   Associated Paragraph Style Name.
  /// </summary>
  public DMW.StyleId? StyleId { get; set; }
  
  
  /// <summary>
  ///   Entry Categorization.
  /// </summary>
  public DMW.Category? Category { get; set; }
  
  
  /// <summary>
  ///   Entry Types.
  /// </summary>
  public DMW.DocPartTypes? DocPartTypes { get; set; }
  
  
  /// <summary>
  ///   Entry Insertion Behaviors.
  /// </summary>
  public DMW.Behaviors? Behaviors { get; set; }
  
  
  /// <summary>
  ///   Description for Entry.
  /// </summary>
  public DMW.Description? Description { get; set; }
  
  
  /// <summary>
  ///   Entry ID.
  /// </summary>
  public String? DocPartId { get; set; }
  
}
