namespace DocumentModel.Math;

/// <summary>
/// Delimiter Function.
/// </summary>
public class DelimiterImpl: ModelElementImpl, Delimiter
{
  public DocumentFormat.OpenXml.Math.Delimiter? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Delimiter?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public DelimiterProperties? DelimiterProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Collection<Base>? Bases
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
