namespace DocumentModel.Drawings;

/// <summary>
/// Non-Visual Connection Shape Drawing Properties.
/// </summary>
public class NonVisualConnectionShapePropertiesImpl: ModelElementImpl, NonVisualConnectionShapeProperties
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public NonVisualConnectionShapePropertiesImpl(): base() {}
  
  public NonVisualConnectionShapePropertiesImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.NonVisualConnectionShapeProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Connection Shape Locks.
  /// </summary>
  public ConnectionShapeLocks? ConnectionShapeLocks
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Connection Start.
  /// </summary>
  public ConnectionType? StartConnection
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Connection End.
  /// </summary>
  public ConnectionType? EndConnection
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
