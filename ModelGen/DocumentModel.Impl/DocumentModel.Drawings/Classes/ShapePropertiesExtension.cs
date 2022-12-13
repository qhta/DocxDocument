namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ShapePropertiesExtension Class.
/// </summary>
public class ShapePropertiesExtensionImpl: ModelElementImpl, ShapePropertiesExtension
{
  public DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapePropertiesExtensionImpl(): base() {}
  
  public ShapePropertiesExtensionImpl(DocumentFormat.OpenXml.Drawing.ShapePropertiesExtension openXmlElement): base(openXmlElement)
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
  
  public DocumentModel.Drawings.HiddenFillProperties? HiddenFillProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.HiddenLineProperties? HiddenLineProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.HiddenEffectsProperties? HiddenEffectsProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.HiddenScene3D? HiddenScene3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public DocumentModel.Drawings.HiddenShape3D? HiddenShape3D
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Boolean? ShadowObscured
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ShadowObscured>();
        return (System.Boolean?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.ShadowObscured>();
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
            item = new DocumentFormat.OpenXml.Office2010.Drawing.ShadowObscured{ Val = (System.Boolean?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
