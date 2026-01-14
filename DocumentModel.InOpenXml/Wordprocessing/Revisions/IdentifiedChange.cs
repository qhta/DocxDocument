namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents a tracked change with a unique identifier in a WordprocessingML document.
  /// This interface provides properties for the change ID, author, and date, enabling identification, tracking, and review of individual revisions within the document.
  /// </summary>
  public class IdentifiedChange: CollectionItem
  {
    
    /// <summary>
    /// Unique identifier for the tracked change, used to reference and manage the revision.
    /// </summary>
    public string? Id { get; set; }
    
    /// <summary>
    /// Author of the tracked change, identifying the user who made the revision.
    /// </summary>
    public string? Author { get; set; }
    
    /// <summary>
    /// Date of the tracked change, specifying when the revision was made.
    /// </summary>
    public DateTime? Date { get; set; }
  }