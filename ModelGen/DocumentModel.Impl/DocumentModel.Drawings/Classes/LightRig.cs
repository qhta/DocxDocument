namespace DocumentModel.Drawings;

/// <summary>
/// Light Rig.
/// </summary>
public partial class LightRigImpl: ModelElementImpl, LightRig
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Drawing.LightRig? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LightRig?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LightRigImpl(): base() {}
  
  public LightRigImpl(DocumentFormat.OpenXml.Drawing.LightRig openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Rig Preset
  /// </summary>
  public DocumentModel.Drawings.LightRigKind? Rig
  {
    get => (DocumentModel.Drawings.LightRigKind?)OpenXmlElement?.Rig?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rig = (DocumentFormat.OpenXml.Drawing.LightRigValues?)value;
    }
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Drawings.LightRigDirectionKind? Direction
  {
    get => (DocumentModel.Drawings.LightRigDirectionKind?)OpenXmlElement?.Direction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Direction = (DocumentFormat.OpenXml.Drawing.LightRigDirectionValues?)value;
    }
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public DocumentModel.Drawings.Rotation? Rotation
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
        if (item != null)
          return new DocumentModel.Drawings.RotationImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.RotationImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
