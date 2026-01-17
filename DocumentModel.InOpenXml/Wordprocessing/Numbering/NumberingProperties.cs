namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the numbering properties for a paragraph or list item in a WordprocessingML document.
/// This interface provides properties for referencing numbering levels, numbering definition instances, previous numbering changes, and inserted numbering properties, enabling advanced list and outline numbering management and revision tracking.
/// </summary>
public class NumberingProperties: ModelElement<DXW.NumberingProperties>
{
    
    /// <summary>
    /// Reference to the numbering level applied to the paragraph or list item.
    /// </summary>
    public Int32? NumberingLevelReference { get; set; }
    
    /// <summary>
    /// Reference to the numbering definition instance used for the paragraph or list item.
    /// </summary>
    public Int32? NumberingId { get; set; }
    
    /// <summary>
    /// Previous paragraph numbering properties, enabling tracking and management of numbering revisions.
    /// </summary>
    public NumberingChange? NumberingChange { get; set; }
    
    /// <summary>
    /// Inserted numbering properties, used to track newly added numbering information as part of revisions.
    /// </summary>
    public TrackChangeType? Inserted { get; set; }
}