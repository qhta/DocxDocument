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
  
  /// <summary>
  /// Upper Limit Properties.
  /// </summary>
  public LimitUpperProperties? LimitUpperProperties
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
  
  /// <summary>
  /// Limit (Upper).
  /// </summary>
  public Limit? Limit
  {
    get;
    set;
  }
  
}
