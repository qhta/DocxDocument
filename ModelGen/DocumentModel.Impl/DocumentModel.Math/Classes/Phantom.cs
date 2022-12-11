namespace DocumentModel.Math;

/// <summary>
/// Phantom Function.
/// </summary>
public class PhantomImpl: ModelElementImpl, Phantom
{
  public DocumentFormat.OpenXml.Math.Phantom? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Phantom?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PhantomImpl(): base() {}
  
  public PhantomImpl(DocumentFormat.OpenXml.Math.Phantom openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public PhantomProperties? PhantomProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
