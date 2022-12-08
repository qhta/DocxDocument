namespace DocumentModel.Drawings;

/// <summary>
/// Defines the BiLevel Class.
/// </summary>
public class BiLevelImpl: ModelElementImpl, BiLevel
{
  public DocumentFormat.OpenXml.Drawing.BiLevel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.BiLevel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Threshold
  /// </summary>
  public Int32? Threshold
  {
    get;
    set;
  }
  
}
