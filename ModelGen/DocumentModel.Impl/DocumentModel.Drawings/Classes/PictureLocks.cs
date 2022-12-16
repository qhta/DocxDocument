namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PictureLocks Class.
/// </summary>
public class PictureLocksImpl: ModelElementImpl, PictureLocks
{
  public DocumentFormat.OpenXml.Drawing.PictureLocks? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.PictureLocks?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PictureLocksImpl(): base() {}
  
  public PictureLocksImpl(DocumentFormat.OpenXml.Drawing.PictureLocks openXmlElement): base(openXmlElement)
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
  /// Disallow Shape Point Editing
  /// </summary>
  public Boolean? NoEditPoints
  {
    get => (System.Boolean?)OpenXmlElement?.NoEditPoints?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.NoAdjustHandles?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.NoChangeArrowheads?.Value;
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
    get => (System.Boolean?)OpenXmlElement?.NoChangeShapeType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoChangeShapeType = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Disallow Crop Changes
  /// </summary>
  public Boolean? NoCrop
  {
    get => (System.Boolean?)OpenXmlElement?.NoCrop?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NoCrop = (System.Boolean?)value;
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
