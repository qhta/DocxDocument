namespace DocumentModel.Drawings.Charts;

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
  
  public DisplayUnitsLabelImpl(): base() {}
  
  public DisplayUnitsLabelImpl(DocumentFormat.OpenXml.Drawing.Charts.DisplayUnitsLabel openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawings.Charts.Layout? Layout
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ChartText.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartText? ChartText
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// TextProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.TextProperties? TextProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
