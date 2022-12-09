namespace DocumentModel.Drawings;

/// <summary>
/// 3D back wall formatting.
/// </summary>
public class BackWallImpl: DocumentModel.Drawings.SurfaceTypeImpl, BackWall
{
  public new DocumentFormat.OpenXml.Drawing.Charts.BackWall? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.BackWall?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override Byte? Thickness
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Thickness>();
        return (Byte?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Thickness>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Byte?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.Charts.Thickness{ Val = (System.Byte?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  public override ShapeProperties5? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override PictureOptions? PictureOptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override ExtensionList3? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
