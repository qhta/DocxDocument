namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents a linked text box within a Wordprocessing document.
/// This interface provides properties for identifying and sequencing linked text boxes, enabling the chaining of text across multiple text boxes for advanced text flow and layout scenarios.
/// </summary>
public interface LinkedTextBox : DMD.IOfficeArtExtendableElement
{
  /// <summary>
  /// The unique identifier for the linked text box, used to distinguish it from other text boxes in the document.
  /// </summary>
  public UInt16? Id { get; set; }

  /// <summary>
  /// The sequence number of the linked text box, indicating its order in a chain of linked text boxes for text flow.
  /// </summary>
  public UInt16? Sequence { get; set; }
}