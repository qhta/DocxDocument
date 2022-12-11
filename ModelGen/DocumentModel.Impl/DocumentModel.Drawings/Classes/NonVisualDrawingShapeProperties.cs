namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualDrawingShapeProperties Class.
/// </summary>
public class NonVisualDrawingShapePropertiesImpl: ModelElementImpl, NonVisualDrawingShapeProperties
{
  public DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualDrawingShapePropertiesImpl(): base() {}
  
  public NonVisualDrawingShapePropertiesImpl(DocumentFormat.OpenXml.Office.Drawing.NonVisualDrawingShapeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Text Box
  /// </summary>
  public Boolean? TextBox
  {
    get => (Boolean?)OpenXmlElement?.TextBox?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TextBox = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shape Locks.
  /// </summary>
  public ShapeLocks? ShapeLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
