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
  
  public DelimiterImpl(): base() {}
  
  public DelimiterImpl(DocumentFormat.OpenXml.Math.Delimiter openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Delimiter Properties.
  /// </summary>
  public DelimiterProperties? DelimiterProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Base? Base
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
