namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines SdtElement, the base interface for structured document tag (SDT) elements in a Wordprocessing document.
/// This interface provides properties for SDT configuration and end character formatting, enabling advanced management and customization of SDT elements.
/// </summary>
public class SdtElement: ModelElement
{

  /// <summary>
  /// Specifies the set of properties applied to this structured document tag.
  /// </summary>
  public SdtProperties? SdtProperties { get; set; }

  /// <summary>
  /// Specifies the properties applied to the physical character that delimits the end of a structured document tag.
  /// </summary>
  public SdtEndCharProperties? SdtEndCharProperties { get; set; }
}