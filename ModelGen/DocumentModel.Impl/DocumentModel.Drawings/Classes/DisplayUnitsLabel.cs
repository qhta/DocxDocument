namespace DocumentModel.Drawings;

/// <summary>
/// Display Units Label.
/// </summary>
public class DisplayUnitsLabelImpl: ModelElementImpl, DisplayUnitsLabel
{
  public DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
  /// ChartText.
  /// </summary>
  public ChartText1? ChartText
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
  
}
