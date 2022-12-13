namespace DocumentModel.Math;

/// <summary>
/// Box Function.
/// </summary>
public class BoxImpl: ModelElementImpl, Box
{
  public DocumentFormat.OpenXml.Math.Box? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Box?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BoxImpl(): base() {}
  
  public BoxImpl(DocumentFormat.OpenXml.Math.Box openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Box Properties.
  /// </summary>
  public DocumentModel.Math.BoxProperties? BoxProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
