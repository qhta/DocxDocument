namespace DocumentModel.Drawings;

/// <summary>
/// Defines the AlphaBiLevel Class.
/// </summary>
public class AlphaBiLevelImpl: ModelElementImpl, AlphaBiLevel
{
  public DocumentFormat.OpenXml.Drawing.AlphaBiLevel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AlphaBiLevel?)_OpenXmlElement;
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
