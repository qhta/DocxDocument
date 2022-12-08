namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public class SdtContentTextImpl: ModelElementImpl, SdtContentText
{
  public DocumentFormat.OpenXml.Wordprocessing.SdtContentText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.SdtContentText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  public Boolean? MultiLine
  {
    get;
    set;
  }
  
}
