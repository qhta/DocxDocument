namespace DocumentModel.Drawings;

/// <summary>
/// Shape.
/// </summary>
public class ShapeImpl: ModelElementImpl, Shape
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
  public DocumentModel.Drawings.AdjustList? AdjustList
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
