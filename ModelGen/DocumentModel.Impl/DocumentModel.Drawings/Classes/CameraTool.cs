namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CameraTool Class.
/// </summary>
public class CameraToolImpl: ModelElementImpl, CameraTool
{
  public DocumentFormat.OpenXml.Office2010.Drawing.CameraTool? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.CameraTool?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// cellRange, this property is only available in Office 2010 and later.
  /// </summary>
  public String? CellRange
  {
    get => (String?)OpenXmlElement?.CellRange?.Value;
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
    get => (String?)OpenXmlElement?.ShapeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeId = (System.String?)value;
    }
  }
  
}
