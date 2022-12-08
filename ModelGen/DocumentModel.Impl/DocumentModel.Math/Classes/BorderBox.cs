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
  
}
