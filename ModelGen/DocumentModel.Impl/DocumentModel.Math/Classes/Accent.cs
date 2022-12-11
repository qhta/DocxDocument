namespace DocumentModel.Math;

/// <summary>
/// Accent.
/// </summary>
public class AccentImpl: ModelElementImpl, Accent
{
  public DocumentFormat.OpenXml.Math.Accent? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Accent?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AccentImpl(): base() {}
  
  public AccentImpl(DocumentFormat.OpenXml.Math.Accent openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Accent Properties.
  /// </summary>
  public AccentProperties? AccentProperties
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
