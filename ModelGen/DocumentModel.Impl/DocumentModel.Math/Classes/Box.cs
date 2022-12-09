namespace DocumentModel.Math;

/// <summary>
/// Box Function.
/// </summary>
public class BoxImpl: ModelElementImpl, Box
{
  public DocumentFormat.OpenXml.Math.Box? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Box?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Box Properties.
  /// </summary>
  public BoxProperties? BoxProperties
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
