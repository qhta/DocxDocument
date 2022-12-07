namespace DocumentModel.Vml;

/// <summary>
/// Shape Layout Properties.
/// </summary>
public class ShapeLayoutImpl: ModelElement<DocumentFormat.OpenXml.Vml.Office.ShapeLayout>, ShapeLayout
{
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Shape ID Map.
  /// </summary>
  public ShapeIdMap? ShapeIdMap
  {
    get;
    set;
  }
  
  /// <summary>
  /// Shape Grouping History.
  /// </summary>
  public RegroupTable? RegroupTable
  {
    get;
    set;
  }
  
  /// <summary>
  /// Rule Set.
  /// </summary>
  public Rules? Rules
  {
    get;
    set;
  }
  
}
