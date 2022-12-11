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
  public LightRigKind? Rig
  {
    get => (LightRigKind?)OpenXmlElement?.Rig?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rig = (DocumentFormat.OpenXml.Drawing.LightRigValues?)value;
    }
  }
  
  /// <summary>
  /// Direction
  /// </summary>
  public LightRigDirectionKind? Direction
  {
    get => (LightRigDirectionKind?)OpenXmlElement?.Direction?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Direction = (DocumentFormat.OpenXml.Drawing.LightRigDirectionValues?)value;
    }
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public Rotation? Rotation
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
