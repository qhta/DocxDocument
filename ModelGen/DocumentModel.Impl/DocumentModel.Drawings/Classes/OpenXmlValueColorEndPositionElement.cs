namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public class OpenXmlValueColorEndPositionElementImpl: ModelElementImpl, OpenXmlValueColorEndPositionElement
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlValueColorEndPositionElement?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  public virtual Boolean? ExtremeValueColorPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public virtual Double? NumberColorPosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public virtual Double? PercentageColorPosition
  {
    get;
    set;
  }
  
}
