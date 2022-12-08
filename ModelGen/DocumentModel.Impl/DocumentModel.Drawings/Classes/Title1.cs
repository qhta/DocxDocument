namespace DocumentModel.Drawings;

/// <summary>
/// Title.
/// </summary>
public class Title1Impl: ModelElementImpl, Title1
{
  public DocumentFormat.OpenXml.Drawing.Charts.Title? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Title?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Chart Text.
  /// </summary>
  public ChartText1? ChartText
  {
    get;
    set;
  }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public Layout2? Layout
  {
    get;
    set;
  }
  
  /// <summary>
  /// Overlay.
  /// </summary>
  public Boolean? Overlay
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public TextProperties2? TextProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
