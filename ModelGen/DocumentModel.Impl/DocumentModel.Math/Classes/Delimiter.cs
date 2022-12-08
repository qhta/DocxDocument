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
    get;
    set;
  }
  
  public Collection<Base>? Bases
  {
    get;
    set;
  }
  
}
