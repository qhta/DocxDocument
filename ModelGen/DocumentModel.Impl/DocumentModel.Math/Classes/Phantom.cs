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
  
  /// <summary>
  /// Phantom Properties.
  /// </summary>
  public PhantomProperties? PhantomProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Base.
  /// </summary>
  public Base? Base
  {
    get;
    set;
  }
  
}
