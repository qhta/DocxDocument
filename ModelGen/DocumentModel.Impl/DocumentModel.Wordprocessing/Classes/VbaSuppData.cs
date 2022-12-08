namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VbaSuppData Class.
/// </summary>
public class VbaSuppDataImpl: ModelElementImpl, VbaSuppData
{
  public DocumentFormat.OpenXml.Office.Word.VbaSuppData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Word.VbaSuppData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// DocEvents.
  /// </summary>
  public DocEvents? DocEvents
  {
    get;
    set;
  }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public Mcds? Mcds
  {
    get;
    set;
  }
  
}
