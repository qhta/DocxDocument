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
  
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public RadicalProperties? RadicalProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public Degree? Degree
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
