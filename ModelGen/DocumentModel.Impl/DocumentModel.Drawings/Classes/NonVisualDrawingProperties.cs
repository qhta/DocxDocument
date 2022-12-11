namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingProperties Class.
/// </summary>
public class NonVisualDrawingPropertiesImpl: ModelElementImpl, NonVisualDrawingProperties
{
  public DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualDrawingPropertiesImpl(): base() {}
  
  public NonVisualDrawingPropertiesImpl(DocumentFormat.OpenXml.Office2010.Drawing.Diagram.NonVisualDrawingProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Application defined unique identifier.
  /// </summary>
  public UInt32? Id
  {
    get => (UInt32?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.UInt32?)value;
    }
  }
  
  /// <summary>
  /// Name compatible with Object Model (non-unique).
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Description of the drawing element.
  /// </summary>
  public String? Description
  {
    get => (String?)OpenXmlElement?.Description?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Description = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Flag determining to show or hide this element.
  /// </summary>
  public Boolean? Hidden
  {
    get => (Boolean?)OpenXmlElement?.Hidden?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Hidden = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Title
  /// </summary>
  public String? Title
  {
    get => (String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink associated with clicking or selecting the element..
  /// </summary>
  public HyperlinkOnClick? HyperlinkOnClick
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hyperlink associated with hovering over the element..
  /// </summary>
  public HyperlinkOnHover? HyperlinkOnHover
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Future extension.
  /// </summary>
  public NonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
