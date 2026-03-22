namespace DocumentModel.Wordprocessing.VBA;
/// <summary>
/// Represents supplementary VBA data for a Wordprocessing document.
/// This class provides access to document events and additional macro data, enabling advanced automation and extensibility for VBA-enabled documents.
/// </summary>
[OpenXmlType(typeof(DXOW.VbaSuppData))]
public class VbaSuppData: ModelElement<DXOW.VbaSuppData>
{
  /// <summary>
  /// Document events associated with the VBA data, enabling event-driven automation and custom behaviors.
  /// </summary>
  [OpenXmlProperty(nameof(DXOW.VbaSuppData.DocEvents))]
  public DocEvents? DocEvents { get => _DocEvents; set => UpdateField(ref _DocEvents, value, nameof(DocEvents)); }
  private DocEvents? _DocEvents;
  /// <summary>
  /// Additional macro data structures, providing extended information and configuration for VBA macros.
  /// </summary>
  [OpenXmlProperty(nameof(DXOW.VbaSuppData.Mcds))]
  public Mcds? Mcds { get => _Mcds; set => UpdateField(ref _Mcds, value, nameof(Mcds)); }
  private Mcds? _Mcds;
}