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
  
  public AudioFromCDImpl(): base() {}
  
  public AudioFromCDImpl(DocumentFormat.OpenXml.Drawing.AudioFromCD openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public AudioCDTimeType? StartTime
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public AudioCDTimeType? EndTime
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
