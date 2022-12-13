namespace DocumentModel.Math;

/// <summary>
/// Upper-Limit Function.
/// </summary>
public class LimitUpperImpl: ModelElementImpl, LimitUpper
{
  public DocumentFormat.OpenXml.Math.LimitUpper? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.LimitUpper?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LimitUpperImpl(): base() {}
  
  public LimitUpperImpl(DocumentFormat.OpenXml.Math.LimitUpper openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  public DocumentModel.Math.LimitUpperProperties? LimitUpperProperties
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
  
  /// <summary>
  /// Limit (Upper).
  /// </summary>
  public DocumentModel.Math.Limit? Limit
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
