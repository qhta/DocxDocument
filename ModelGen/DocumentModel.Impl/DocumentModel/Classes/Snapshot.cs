namespace DocumentModel;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public class SnapshotImpl: ModelElement<DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot>, Snapshot
{
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public DocumentModel.Drawings.BlipCompressionKind? CompressionState
  {
    get => (DocumentModel.Drawings.BlipCompressionKind?)OpenXmlElement?.CompressionState?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompressionState = (DocumentFormat.OpenXml.Drawing.BlipCompressionValues?)value;
    }
  }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList
  {
    get;
    set;
  }
  
}
