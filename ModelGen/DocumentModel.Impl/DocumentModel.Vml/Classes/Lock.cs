namespace DocumentModel.Vml;

/// <summary>
/// Defines the Lock Class.
/// </summary>
public partial class LockImpl: ModelElementImpl, Lock
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.Lock? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.Lock?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public LockImpl(): base() {}
  
  public LockImpl(DocumentFormat.OpenXml.Vml.Office.Lock openXmlElement): base(openXmlElement)
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
  /// Position Lock
  /// </summary>
  public Boolean? Position
  {
    get => (System.Boolean?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Selection Lock
  /// </summary>
  public Boolean? Selection
  {
    get => (System.Boolean?)OpenXmlElement?.Selection?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Selection = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Grouping Lock
  /// </summary>
  public Boolean? Grouping
  {
    get => (System.Boolean?)OpenXmlElement?.Grouping?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Grouping = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Ungrouping Lock
  /// </summary>
  public Boolean? Ungrouping
  {
    get => (System.Boolean?)OpenXmlElement?.Ungrouping?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Ungrouping = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Rotation Lock
  /// </summary>
  public Boolean? Rotation
  {
    get => (System.Boolean?)OpenXmlElement?.Rotation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rotation = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Cropping Lock
  /// </summary>
  public Boolean? Cropping
  {
    get => (System.Boolean?)OpenXmlElement?.Cropping?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Cropping = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Vertices Lock
  /// </summary>
  public Boolean? Verticies
  {
    get => (System.Boolean?)OpenXmlElement?.Verticies?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Verticies = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Handles Lock
  /// </summary>
  public Boolean? AdjustHandles
  {
    get => (System.Boolean?)OpenXmlElement?.AdjustHandles?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AdjustHandles = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Text Lock
  /// </summary>
  public Boolean? TextLock
  {
    get => (System.Boolean?)OpenXmlElement?.TextLock?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TextLock = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Aspect Ratio Lock
  /// </summary>
  public Boolean? AspectRatio
  {
    get => (System.Boolean?)OpenXmlElement?.AspectRatio?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AspectRatio = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// AutoShape Type Lock
  /// </summary>
  public Boolean? ShapeType
  {
    get => (System.Boolean?)OpenXmlElement?.ShapeType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ShapeType = (System.Boolean?)value;
    }
  }
  
}
