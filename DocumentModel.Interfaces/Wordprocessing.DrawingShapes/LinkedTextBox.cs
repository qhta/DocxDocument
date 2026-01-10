namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Represents a linked text box within a Wordprocessing document.
/// This interface provides properties for identifying and sequencing linked text boxes, as well as for storing additional extension data.
/// </summary>
public interface LinkedTextBox: DMD.OfficeArtExtendableElement
{
    /// <summary>
    /// The unique identifier for the linked text box, used to distinguish it from other text boxes in the document.
    /// </summary>
    public UInt16? Id { get; set; }
    /// <summary>
    /// The sequence number of the linked text box, indicating its order in a chain of linked text boxes.
    /// </summary>
    public UInt16? Sequence { get; set; }

}