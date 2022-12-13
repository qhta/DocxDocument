namespace DocumentModel.Drawings;

/// <summary>
/// Light Rig.
/// </summary>
public class LightRigImpl: ModelElementImpl, LightRig
{
  public DocumentFormat.OpenXml.Drawing.LightRig? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LightRig?)_OpenXmlElement;
    set => _OpenXmlElement = value;
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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
