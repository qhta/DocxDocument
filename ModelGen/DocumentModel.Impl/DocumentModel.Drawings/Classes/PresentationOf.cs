namespace DocumentModel.Drawings;

/// <summary>
/// Presentation Of.
/// </summary>
public class PresentationOfImpl: ModelElementImpl, PresentationOf
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PresentationOfImpl(): base() {}
  
  public PresentationOfImpl(DocumentFormat.OpenXml.Drawing.Diagrams.PresentationOf openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<DocumentModel.Drawings.AxisKind>? Axis
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<DocumentModel.Drawings.ElementKind>? PointType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<System.Boolean>? HideLastTrans
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<System.Int32>? Start
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<System.UInt32>? Count
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<System.Int32>? Step
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
