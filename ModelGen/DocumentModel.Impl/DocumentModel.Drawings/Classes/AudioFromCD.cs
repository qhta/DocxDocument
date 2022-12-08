namespace DocumentModel.Drawings;

/// <summary>
/// Audio from CD.
/// </summary>
public class AudioFromCDImpl: ModelElementImpl, AudioFromCD
{
  public DocumentFormat.OpenXml.Drawing.AudioFromCD? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AudioFromCD?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public AudioCDTimeType? StartTime
  {
    get;
    set;
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public AudioCDTimeType? EndTime
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
