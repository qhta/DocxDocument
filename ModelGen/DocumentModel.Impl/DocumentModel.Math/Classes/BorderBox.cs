namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public class BorderBoxImpl: ModelElementImpl, BorderBox
{
  public DocumentFormat.OpenXml.Math.BorderBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.BorderBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BorderBoxImpl(): base() {}
  
  public BorderBoxImpl(DocumentFormat.OpenXml.Math.BorderBox openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public DocumentModel.Math.BorderBoxProperties? BorderBoxProperties
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
