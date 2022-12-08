namespace DocumentModel.Math;

/// <summary>
/// Radical Function.
/// </summary>
public class RadicalImpl: ModelElementImpl, Radical
{
  public DocumentFormat.OpenXml.Math.Radical? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.Radical?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public RadicalProperties? RadicalProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public Degree? Degree
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
