namespace DocumentModel.Math;

/// <summary>
/// Lower-Limit Function.
/// </summary>
public class LimitLowerImpl: ModelElementImpl, LimitLower
{
  public DocumentFormat.OpenXml.Math.LimitLower? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.LimitLower?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Lower Limit Properties.
  /// </summary>
  public LimitLowerProperties? LimitLowerProperties
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
  
  /// <summary>
  /// Limit (Lower).
  /// </summary>
  public Limit? Limit
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
