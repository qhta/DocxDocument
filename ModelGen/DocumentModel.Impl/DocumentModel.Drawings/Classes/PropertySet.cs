namespace DocumentModel.Drawings;

/// <summary>
/// Property Set.
/// </summary>
public class PropertySetImpl: ModelElementImpl, PropertySet
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PropertySetImpl(): base() {}
  
  public PropertySetImpl(DocumentFormat.OpenXml.Drawing.Diagrams.PropertySet openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Presentation Element Identifier
  /// </summary>
  public String? PresentationElementId
  {
    get => (System.String?)OpenXmlElement?.PresentationElementId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresentationElementId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Presentation Name
  /// </summary>
  public String? PresentationName
  {
    get => (System.String?)OpenXmlElement?.PresentationName?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresentationName = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Presentation Style Label
  /// </summary>
  public String? PresentationStyleLabel
  {
    get => (System.String?)OpenXmlElement?.PresentationStyleLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresentationStyleLabel = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Presentation Style Index
  /// </summary>
  public Int32? PresentationStyleIndex
  {
    get => (System.Int32?)OpenXmlElement?.PresentationStyleIndex?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresentationStyleIndex = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Presentation Style Count
  /// </summary>
  public Int32? PresentationStyleCount
  {
    get => (System.Int32?)OpenXmlElement?.PresentationStyleCount?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PresentationStyleCount = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Current Diagram Type
  /// </summary>
  public String? LayoutTypeId
  {
    get => (System.String?)OpenXmlElement?.LayoutTypeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LayoutTypeId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Current Diagram Category
  /// </summary>
  public String? LayoutCategoryId
  {
    get => (System.String?)OpenXmlElement?.LayoutCategoryId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.LayoutCategoryId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Current Style Type
  /// </summary>
  public String? QuickStyleTypeId
  {
    get => (System.String?)OpenXmlElement?.QuickStyleTypeId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QuickStyleTypeId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Current Style Category
  /// </summary>
  public String? QuickStyleCategoryId
  {
    get => (System.String?)OpenXmlElement?.QuickStyleCategoryId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.QuickStyleCategoryId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Color Transform Type Identifier
  /// </summary>
  public String? ColorType
  {
    get => (System.String?)OpenXmlElement?.ColorType?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColorType = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Color Transform Category
  /// </summary>
  public String? ColorCategoryId
  {
    get => (System.String?)OpenXmlElement?.ColorCategoryId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ColorCategoryId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Coherent 3D Behavior
  /// </summary>
  public Boolean? Coherent3D
  {
    get => (System.Boolean?)OpenXmlElement?.Coherent3D?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Coherent3D = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Placeholder Text
  /// </summary>
  public String? PlaceholderText
  {
    get => (System.String?)OpenXmlElement?.PlaceholderText?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PlaceholderText = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Placeholder
  /// </summary>
  public Boolean? Placeholder
  {
    get => (System.Boolean?)OpenXmlElement?.Placeholder?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Placeholder = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Custom Rotation
  /// </summary>
  public Int32? Rotation
  {
    get => (System.Int32?)OpenXmlElement?.Rotation?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rotation = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Custom Vertical Flip
  /// </summary>
  public Boolean? VerticalFlip
  {
    get => (System.Boolean?)OpenXmlElement?.VerticalFlip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.VerticalFlip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Custom Horizontal Flip
  /// </summary>
  public Boolean? HorizontalFlip
  {
    get => (System.Boolean?)OpenXmlElement?.HorizontalFlip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HorizontalFlip = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Fixed Width Override
  /// </summary>
  public Int32? FixedWidthOverride
  {
    get => (System.Int32?)OpenXmlElement?.FixedWidthOverride?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FixedWidthOverride = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Fixed Height Override
  /// </summary>
  public Int32? FixedHeightOverride
  {
    get => (System.Int32?)OpenXmlElement?.FixedHeightOverride?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FixedHeightOverride = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Width Scale
  /// </summary>
  public Int32? WidthScale
  {
    get => (System.Int32?)OpenXmlElement?.WidthScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.WidthScale = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Height Scale
  /// </summary>
  public Int32? HightScale
  {
    get => (System.Int32?)OpenXmlElement?.HightScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HightScale = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Text Changed
  /// </summary>
  public Boolean? TextChanged
  {
    get => (System.Boolean?)OpenXmlElement?.TextChanged?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.TextChanged = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Custom Factor Width
  /// </summary>
  public Int32? FactorWidth
  {
    get => (System.Int32?)OpenXmlElement?.FactorWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FactorWidth = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Custom Factor Height
  /// </summary>
  public Int32? FactorHeight
  {
    get => (System.Int32?)OpenXmlElement?.FactorHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FactorHeight = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Neighbor Offset Width
  /// </summary>
  public Int32? NeighborOffsetWidth
  {
    get => (System.Int32?)OpenXmlElement?.NeighborOffsetWidth?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NeighborOffsetWidth = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Neighbor Offset Height
  /// </summary>
  public Int32? NeighborOffsetHeight
  {
    get => (System.Int32?)OpenXmlElement?.NeighborOffsetHeight?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NeighborOffsetHeight = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Radius Scale
  /// </summary>
  public Int32? RadiusScale
  {
    get => (System.Int32?)OpenXmlElement?.RadiusScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RadiusScale = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Include Angle Scale
  /// </summary>
  public Int32? IncludeAngleScale
  {
    get => (System.Int32?)OpenXmlElement?.IncludeAngleScale?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IncludeAngleScale = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// Presentation Layout Variables.
  /// </summary>
  public DocumentModel.Drawings.PresentationLayoutVariables? PresentationLayoutVariables
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public DocumentModel.Drawings.Style? Style
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
