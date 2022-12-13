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
  public DocumentModel.Drawings.AudioCDTimeType? StartTime
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public DocumentModel.Drawings.AudioCDTimeType? EndTime
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
