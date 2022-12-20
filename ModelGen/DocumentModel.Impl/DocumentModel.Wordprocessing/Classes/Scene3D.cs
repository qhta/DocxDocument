namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public partial class Scene3DImpl: ModelElementImpl, Scene3D
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Word.Scene3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Scene3D?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public Scene3DImpl(): base() {}
  
  public Scene3DImpl(DocumentFormat.OpenXml.Office2010.Word.Scene3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Wordprocessing.Camera? Camera
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Camera>();
        if (item != null)
          return new DocumentModel.Wordprocessing.CameraImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.Camera>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.CameraImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public DocumentModel.Wordprocessing.LightRig? LightRig
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LightRig>();
        if (item != null)
          return new DocumentModel.Wordprocessing.LightRigImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Word.LightRig>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Wordprocessing.LightRigImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
