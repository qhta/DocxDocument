namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Frame Locks.
/// </summary>
public class GraphicFrameLocksImpl: ModelElementImpl, GraphicFrameLocks
{
  public DocumentFormat.OpenXml.Drawing.GraphicFrameLocks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GraphicFrameLocks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GraphicFrameLocksImpl(): base() {}
  
  public GraphicFrameLocksImpl(DocumentFormat.OpenXml.Drawing.GraphicFrameLocks openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public Boolean? NoGrouping
  {
    get => (System.Boolean?)OpenXmlElement?.NoGrouping?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoGrouping = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Selection of Child Shapes
  /// </summary>
  public Boolean? NoDrilldown
  {
    get => (System.Boolean?)OpenXmlElement?.NoDrilldown?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoDrilldown = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public Boolean? NoSelection
  {
    get => (System.Boolean?)OpenXmlElement?.NoSelection?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoSelection = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect
  {
    get => (System.Boolean?)OpenXmlElement?.NoChangeAspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoChangeAspect = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Movement
  /// </summary>
  public Boolean? NoMove
  {
    get => (System.Boolean?)OpenXmlElement?.NoMove?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoMove = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Resize
  /// </summary>
  public Boolean? NoResize
  {
    get => (System.Boolean?)OpenXmlElement?.NoResize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoResize = (System.Boolean?)value;
    }
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
