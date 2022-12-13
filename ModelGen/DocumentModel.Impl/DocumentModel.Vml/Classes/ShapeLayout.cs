namespace DocumentModel.Vml;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public class ShapeLayoutImpl: ModelElementImpl, ShapeLayout
{
  public DocumentFormat.OpenXml.Vml.Office.ShapeLayout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.ShapeLayout?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeLayoutImpl(): base() {}
  
  public ShapeLayoutImpl(DocumentFormat.OpenXml.Vml.Office.ShapeLayout openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  public DocumentModel.Vml.ShapeIdMap? ShapeIdMap
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public DocumentModel.Vml.RegroupTable? RegroupTable
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public DocumentModel.Vml.Rules? Rules
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
