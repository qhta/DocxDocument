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
  
  public LightRigImpl(): base() {}
  
  public LightRigImpl(DocumentFormat.OpenXml.Office2010.Word.LightRig openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// rig, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.LightRigKind? LightRigType
  {
    get => (DocumentModel.Wordprocessing.LightRigKind?)OpenXmlElement?.LightRigType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightRigType = (DocumentFormat.OpenXml.Office2010.Word.LightRigTypeValues?)value;
    }
  }
  
  /// <summary>
  /// dir, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.LightRigDirectionKind? LightDirectionType
  {
    get => (DocumentModel.Wordprocessing.LightRigDirectionKind?)OpenXmlElement?.LightDirectionType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LightDirectionType = (DocumentFormat.OpenXml.Office2010.Word.LightRigDirectionValues?)value;
    }
  }
  
  /// <summary>
  /// SphereCoordinates.
  /// </summary>
  public DocumentModel.Wordprocessing.SphereCoordinates? SphereCoordinates
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
