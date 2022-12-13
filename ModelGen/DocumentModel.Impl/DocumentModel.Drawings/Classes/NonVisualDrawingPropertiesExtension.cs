namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingPropertiesExtension Class.
/// </summary>
public class NonVisualDrawingPropertiesExtensionImpl: ModelElementImpl, NonVisualDrawingPropertiesExtension
{
  public DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualDrawingPropertiesExtensionImpl(): base() {}
  
  public NonVisualDrawingPropertiesExtensionImpl(DocumentFormat.OpenXml.Drawing.NonVisualDrawingPropertiesExtension openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get => (System.String?)OpenXmlElement?.Uri?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Uri = (System.String?)value;
    }
  }
  
  public DocumentModel.Drawings.CompatExtension? CompatExtension
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings13.BackgroundProperties? BackgroundProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.CreationId? CreationId
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings16.PredecessorDrawingElementReference? PredecessorDrawingElementReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? Decorative
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Decorative>();
        return (System.Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2019.Drawing.Decorative>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Boolean?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2019.Drawing.Decorative{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public DocumentModel.Drawings.ClassificationOutcome? ClassificationOutcome
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.ScriptLink? ScriptLink
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
