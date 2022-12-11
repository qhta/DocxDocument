namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ApplicationNonVisualDrawingProperties Class.
/// </summary>
public class ApplicationNonVisualDrawingPropertiesImpl: ModelElementImpl, ApplicationNonVisualDrawingProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ApplicationNonVisualDrawingPropertiesImpl(): base() {}
  
  public ApplicationNonVisualDrawingPropertiesImpl(DocumentFormat.OpenXml.Office2010.Drawing.ChartDrawing.ApplicationNonVisualDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// macro, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Macro
  {
    get => (String?)OpenXmlElement?.Macro?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Macro = (System.String?)value;
    }
  }
  
  /// <summary>
  /// fPublished, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Published
  {
    get => (Boolean?)OpenXmlElement?.Published?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Published = (System.Boolean?)value;
    }
  }
  
}
