namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public class ExternalData1Impl: ModelElementImpl, ExternalData1
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExternalData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public Boolean? AutoUpdate
  {
    get;
    set;
  }
  
}
