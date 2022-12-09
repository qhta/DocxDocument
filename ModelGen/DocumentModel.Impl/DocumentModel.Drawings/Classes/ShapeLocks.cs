namespace DocumentModel.Drawings;

/// <summary>
/// Shape Locks.
/// </summary>
public class ShapeLocksImpl: ModelElementImpl, ShapeLocks
{
  public DocumentFormat.OpenXml.Drawing.ShapeLocks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ShapeLocks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Disallow Shape Grouping
  /// </summary>
  public Boolean? NoGrouping
  {
    get => (Boolean?)OpenXmlElement?.NoGrouping?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoGrouping = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Selection
  /// </summary>
  public Boolean? NoSelection
  {
    get => (Boolean?)OpenXmlElement?.NoSelection?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoSelection = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Rotation
  /// </summary>
  public Boolean? NoRotation
  {
    get => (Boolean?)OpenXmlElement?.NoRotation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoRotation = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Aspect Ratio Change
  /// </summary>
  public Boolean? NoChangeAspect
  {
    get => (Boolean?)OpenXmlElement?.NoChangeAspect?.Value;
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
    get => (Boolean?)OpenXmlElement?.NoMove?.Value;
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
    get => (Boolean?)OpenXmlElement?.NoResize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoResize = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Point Editing
  /// </summary>
  public Boolean? NoEditPoints
  {
    get => (Boolean?)OpenXmlElement?.NoEditPoints?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoEditPoints = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Showing Adjust Handles
  /// </summary>
  public Boolean? NoAdjustHandles
  {
    get => (Boolean?)OpenXmlElement?.NoAdjustHandles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoAdjustHandles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Arrowhead Changes
  /// </summary>
  public Boolean? NoChangeArrowheads
  {
    get => (Boolean?)OpenXmlElement?.NoChangeArrowheads?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoChangeArrowheads = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Type Change
  /// </summary>
  public Boolean? NoChangeShapeType
  {
    get => (Boolean?)OpenXmlElement?.NoChangeShapeType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoChangeShapeType = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Shape Text Editing
  /// </summary>
  public Boolean? NoTextEdit
  {
    get => (Boolean?)OpenXmlElement?.NoTextEdit?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoTextEdit = (System.Boolean?)value;
    }
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
