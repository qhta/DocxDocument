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
  
  public VbaSuppDataImpl(): base() {}
  
  public VbaSuppDataImpl(DocumentFormat.OpenXml.Office.Word.VbaSuppData openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// DocEvents.
  /// </summary>
  public DocEvents? DocEvents
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Mcds.
  /// </summary>
  public Mcds? Mcds
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
