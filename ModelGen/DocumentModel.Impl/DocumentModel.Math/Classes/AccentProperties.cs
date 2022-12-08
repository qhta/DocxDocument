namespace DocumentModel.Math;

/// <summary>
/// Accent Properties.
/// </summary>
public class AccentPropertiesImpl: ModelElementImpl, AccentProperties
{
  public DocumentFormat.OpenXml.Math.AccentProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.AccentProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Accent Character.
  /// </summary>
  public String? AccentChar
  {
    get;
    set;
  }
  
  /// <summary>
  /// Control Properties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
