namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CameraTool Class.
/// </summary>
public partial class CameraToolImpl: ModelElementImpl, CameraTool
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.CameraTool? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.CameraTool?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public CameraToolImpl(): base() {}
  
  public CameraToolImpl(DocumentFormat.OpenXml.Office2010.Drawing.CameraTool openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  public String? CellRange
  {
    get => (System.String?)OpenXmlElement?.CellRange?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CellRange = (System.String?)value;
    }
  }
  
  /// <summary>
  /// spid, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ShapeId
  {
    get => (System.String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
  }
  
}
