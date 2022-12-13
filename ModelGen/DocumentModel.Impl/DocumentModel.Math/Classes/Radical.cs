namespace DocumentModel.Math;

/// <summary>
/// Radical Function.
/// </summary>
public class RadicalImpl: ModelElementImpl, Radical
{
  public DocumentFormat.OpenXml.Math.Radical? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Radical?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RadicalImpl(): base() {}
  
  public RadicalImpl(DocumentFormat.OpenXml.Math.Radical openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public DocumentModel.Math.RadicalProperties? RadicalProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public DocumentModel.Math.Degree? Degree
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
