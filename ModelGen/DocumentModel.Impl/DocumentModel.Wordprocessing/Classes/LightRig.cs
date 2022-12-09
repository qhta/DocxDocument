namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LightRig Class.
/// </summary>
public class LightRigImpl: ModelElementImpl, LightRig
{
  public DocumentFormat.OpenXml.Office2010.Word.LightRig? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.LightRig?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  public LightRigKind? LightRigType
  {
    get => (LightRigKind?)OpenXmlElement?.LightRigType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightRigType = (DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues?)value;
    }
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public LightRigDirectionKind? LightDirectionType
  {
    get => (LightRigDirectionKind?)OpenXmlElement?.LightDirectionType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightDirectionType = (DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues?)value;
    }
  }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  public SphereCoordinates? SphereCoordinates
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
