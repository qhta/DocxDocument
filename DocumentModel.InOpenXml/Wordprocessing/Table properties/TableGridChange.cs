namespace DocumentModel.Wordprocessing;

  /// <summary>
  /// Represents revision information for table grid column definitions in a Wordprocessing document.
  /// This interface provides properties for annotation identification and previous table grid configuration, enabling tracking and management of grid revisions.
  /// </summary>
  public class TableGridChange: ModelElement<DXW.TableGridChange>
  {
    
    /// <summary>
    /// Annotation identifier for the table grid change, used to uniquely identify the revision.
    /// </summary>
    public string? AnnotationId { get; set; }
    
    /// <summary>
    /// Previous table grid configuration before the change, enabling comparison and tracking of grid revisions.
    /// </summary>
    public PreviousTableGrid? PreviousTableGrid { get; set; }
  }