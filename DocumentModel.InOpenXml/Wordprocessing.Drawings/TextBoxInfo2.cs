namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents advanced information for a text box in a Wordprocessing document.
/// This interface provides properties for identifying the text box, accessing its content, and managing associated OfficeArt extensions, enabling advanced text box configuration and extensibility.
/// </summary>
public interface TextBoxInfo2 : DMD.IOfficeArtExtendableElement
{

  /// <summary>
  /// The unique identifier for the text box, used to distinguish it from other text boxes in the document.
  /// </summary>
  public UInt16? Id { get; set; }

  /// <summary>
  /// The content of the text box, including text and formatting information.
  /// </summary>
  public TextBoxContent? TextBoxContent { get; set; }

}