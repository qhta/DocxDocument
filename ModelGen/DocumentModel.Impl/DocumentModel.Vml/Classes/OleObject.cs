namespace DocumentModel.Vml;

/// <summary>
/// Embedded OLE Object.
/// </summary>
public class OleObjectImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.OleObject>, OleObject
{
  /// <summary>
  /// OLE Object Type
  /// </summary>
  public OleKind? Type
  {
    get => (OleKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.OleValues?)value;
    }
  }
  
  /// <summary>
  /// OLE Object Representation
  /// </summary>
  public OleDrawAspectKind? DrawAspect
  {
    get => (OleDrawAspectKind?)OpenXmlElement?.DrawAspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DrawAspect = (DocumentFormat.OpenXml.Vml.Office.OleDrawAspectValues?)value;
    }
  }
  
  /// <summary>
  /// OLE Update Mode
  /// </summary>
  public OleUpdateMode? UpdateMode
  {
    get => (OleUpdateMode?)OpenXmlElement?.UpdateMode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.UpdateMode = (DocumentFormat.OpenXml.Vml.Office.OleUpdateModeValues?)value;
    }
  }
  
}
