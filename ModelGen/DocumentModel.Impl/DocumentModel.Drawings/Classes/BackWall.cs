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
  
  public BackWallImpl(): base() {}
  
  public BackWallImpl(DocumentFormat.OpenXml.Drawing.Charts.BackWall openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new Byte? Thickness
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Thickness>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Byte?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Drawing.Charts.Thickness{ Val = (System.Byte?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  public new ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new PictureOptions? PictureOptions
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
