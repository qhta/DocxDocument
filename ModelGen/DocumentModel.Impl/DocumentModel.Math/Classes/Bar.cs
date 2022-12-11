namespace DocumentModel.Math;

/// <summary>
/// Bar.
/// </summary>
public class BarImpl: ModelElementImpl, Bar
{
  public DocumentFormat.OpenXml.Math.Bar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Bar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BarImpl(): base() {}
  
  public BarImpl(DocumentFormat.OpenXml.Math.Bar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Bar Properties.
  /// </summary>
  public BarProperties? BarProperties
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
