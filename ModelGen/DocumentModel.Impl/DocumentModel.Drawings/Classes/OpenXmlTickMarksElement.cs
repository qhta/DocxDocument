namespace DocumentModel.Drawings;

/// <summary>
/// Defines the OpenXmlTickMarksElement Class.
/// </summary>
public class OpenXmlTickMarksElementImpl: ModelElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.OpenXmlTickMarksElement>, OpenXmlTickMarksElement
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  public TickMarksType? Type
  {
    get => (TickMarksType?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickMarksType?)value;
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual ExtensionList2? ExtensionList
  {
    get;
    set;
  }
  
}
