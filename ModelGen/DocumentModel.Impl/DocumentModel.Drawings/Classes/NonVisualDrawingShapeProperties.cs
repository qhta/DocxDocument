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
  public ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
