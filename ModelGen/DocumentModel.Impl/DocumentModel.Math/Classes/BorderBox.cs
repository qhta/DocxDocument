namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public class BorderBoxImpl: ModelElementImpl, BorderBox
{
  public DocumentFormat.OpenXml.Math.BorderBox? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.BorderBox?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public BorderBoxProperties? BorderBoxProperties
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
