namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupDrawingShapePropsExtension Class.
/// </summary>
public class NonVisualGroupDrawingShapePropsExtensionImpl: ModelElementImpl, NonVisualGroupDrawingShapePropsExtension
{
  public DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.NonVisualGroupDrawingShapePropsExtension?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
  public NonVisualGroupProperties? NonVisualGroupProperties
  {
    get;
    set;
  }
  
}
