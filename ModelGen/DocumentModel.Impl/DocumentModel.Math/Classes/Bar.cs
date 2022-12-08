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
  
  /// <summary>
  /// Bar Properties.
  /// </summary>
  public BarProperties? BarProperties
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
