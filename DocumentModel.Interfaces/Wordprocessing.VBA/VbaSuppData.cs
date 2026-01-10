namespace DocumentModel.Wordprocessing.VBA;

/// <summary>
/// Represents supplementary VBA data for a Wordprocessing document.
/// This interface provides access to document events and additional macro data, enabling advanced automation and extensibility for VBA-enabled documents.
/// </summary>
public interface VbaSuppData
{

  /// <summary>
  /// Document events associated with the VBA data, enabling event-driven automation and custom behaviors.
  /// </summary>
  public DocEvents? DocEvents { get; set; }

  /// <summary>
  /// Additional macro data structures, providing extended information and configuration for VBA macros.
  /// </summary>
  public Mcds? Mcds { get; set; }
}