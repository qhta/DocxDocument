namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the UpDownBarType Class.
/// </summary>
public class UpDownBarTypeImpl: ModelElementImpl, UpDownBarType
{
  public DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public UpDownBarTypeImpl(): base() {}
  
  public UpDownBarTypeImpl(DocumentFormat.OpenXml.Drawing.Charts.UpDownBarType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.Charts.ChartShapeProperties? ChartShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
