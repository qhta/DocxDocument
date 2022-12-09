namespace DocumentModel.Drawings;

/// <summary>
/// Shape.
/// </summary>
public class Shape2Impl: ModelElementImpl, Shape2
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Rotation
  /// </summary>
  public Double? Rotation
  {
    get => (Double?)OpenXmlElement?.Rotation?.Value;
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
    get => (String?)OpenXmlElement?.Type?.Value;
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
    get => (String?)OpenXmlElement?.Blip?.Value;
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
    get => (Int32?)OpenXmlElement?.ZOrderOffset?.Value;
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
    get => (Boolean?)OpenXmlElement?.HideGeometry?.Value;
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
    get => (Boolean?)OpenXmlElement?.LockedText?.Value;
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
    get => (Boolean?)OpenXmlElement?.BlipPlaceholder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BlipPlaceholder = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Shape Adjust List.
  /// </summary>
  public AdjustList? AdjustList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
