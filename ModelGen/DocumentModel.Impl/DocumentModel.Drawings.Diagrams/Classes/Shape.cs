namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Shape.
/// </summary>
public partial class ShapeImpl: ModelElementImpl, Shape
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeImpl(): base() {}
  
  public ShapeImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Shape openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Rotation
  /// </summary>
  public Double? Rotation
  {
    get => (System.Double?)OpenXmlElement?.Rotation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rotation = (System.Double?)value;
    }
  }
  
  /// <summary>
  /// Shape Type
  /// </summary>
  public String? Type
  {
    get => (System.String?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Relationship to Image Part
  /// </summary>
  public String? Blip
  {
    get => (System.String?)OpenXmlElement?.Blip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Blip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Z-Order Offset
  /// </summary>
  public Int32? ZOrderOffset
  {
    get => (System.Int32?)OpenXmlElement?.ZOrderOffset?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ZOrderOffset = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Hide Geometry
  /// </summary>
  public Boolean? HideGeometry
  {
    get => (System.Boolean?)OpenXmlElement?.HideGeometry?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HideGeometry = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Prevent Text Editing
  /// </summary>
  public Boolean? LockedText
  {
    get => (System.Boolean?)OpenXmlElement?.LockedText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LockedText = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Image Placeholder
  /// </summary>
  public Boolean? BlipPlaceholder
  {
    get => (System.Boolean?)OpenXmlElement?.BlipPlaceholder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlipPlaceholder = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.AdjustList? AdjustList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.AdjustListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.AdjustList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.AdjustListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ExtensionList? ExtensionList
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          return new DocumentModel.Drawings.Diagrams.ExtensionListImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Diagrams.ExtensionList>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.Diagrams.ExtensionListImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
