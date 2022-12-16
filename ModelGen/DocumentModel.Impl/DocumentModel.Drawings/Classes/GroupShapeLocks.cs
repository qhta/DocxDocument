namespace DocumentModel.Drawings;

/// <summary>
/// Defines the GroupShapeLocks Class.
/// </summary>
public class GroupShapeLocksImpl: ModelElementImpl, GroupShapeLocks
{
  public DocumentFormat.OpenXml.Drawing.GroupShapeLocks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GroupShapeLocks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public GroupShapeLocksImpl(): base() {}
  
  public GroupShapeLocksImpl(DocumentFormat.OpenXml.Drawing.GroupShapeLocks openXmlElement): base(openXmlElement)
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
  /// Disallow Shape Ungrouping
  /// </summary>
  public Boolean? NoUngrouping
  {
    get => (System.Boolean?)OpenXmlElement?.NoUngrouping?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoUngrouping = (System.Boolean?)value;
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
  /// Disallow Shape Rotation
  /// </summary>
  public Boolean? NoRotation
  {
    get => (System.Boolean?)OpenXmlElement?.NoRotation?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.NoChangeAspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoChangeAspect = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Moving Shape
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
  /// Disallow Shape Resizing
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
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
