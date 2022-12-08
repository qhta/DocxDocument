namespace DocumentModel.Drawings;

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
  
  /// <summary>
  /// ChartShapeProperties.
  /// </summary>
  public virtual ChartShapeProperties? ChartShapeProperties
  {
    get;
    set;
  }
  
}
