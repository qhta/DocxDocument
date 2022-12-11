namespace DocumentModel.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public class FillImpl: ModelElementImpl, Fill
{
  public DocumentFormat.OpenXml.Vml.Fill? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Fill?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FillImpl(): base() {}
  
  public FillImpl(DocumentFormat.OpenXml.Vml.Fill openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Unique Identifier
  /// </summary>
  public String? Id
  {
    get => (String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillKind? Type
  {
    get => (FillKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.FillTypeValues?)value;
    }
  }
  
  /// <summary>
  /// Fill Toggle
  /// </summary>
  public Boolean? On
  {
    get => (Boolean?)OpenXmlElement?.On?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.On = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Primary Color
  /// </summary>
  public String? Color
  {
    get => (String?)OpenXmlElement?.Color?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Primary Color Opacity
  /// </summary>
  public String? Opacity
  {
    get => (String?)OpenXmlElement?.Opacity?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Opacity = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Secondary Color
  /// </summary>
  public String? Color2
  {
    get => (String?)OpenXmlElement?.Color2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Fill Image Source
  /// </summary>
  public String? Source
  {
    get => (String?)OpenXmlElement?.Source?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Source = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public String? Href
  {
    get => (String?)OpenXmlElement?.Href?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Href = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Alternate Image Reference Location
  /// </summary>
  public String? AlternateImageReference
  {
    get => (String?)OpenXmlElement?.AlternateImageReference?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlternateImageReference = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Fill Image Size
  /// </summary>
  public String? Size
  {
    get => (String?)OpenXmlElement?.Size?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Fill Image Origin
  /// </summary>
  public String? Origin
  {
    get => (String?)OpenXmlElement?.Origin?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Origin = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Fill Image Position
  /// </summary>
  public String? Position
  {
    get => (String?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  public ImageAspectKind? Aspect
  {
    get => (ImageAspectKind?)OpenXmlElement?.Aspect?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Aspect = (DocumentFormat.OpenXml.Vml.ImageAspectValues?)value;
    }
  }
  
  /// <summary>
  /// Intermediate Colors
  /// </summary>
  public String? Colors
  {
    get => (String?)OpenXmlElement?.Colors?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Colors = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Gradient Angle
  /// </summary>
  public Decimal? Angle
  {
    get => (Decimal?)OpenXmlElement?.Angle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Angle = (System.Decimal?)value;
    }
  }
  
  /// <summary>
  /// Align Image With Shape
  /// </summary>
  public Boolean? AlignShape
  {
    get => (Boolean?)OpenXmlElement?.AlignShape?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AlignShape = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Gradient Center
  /// </summary>
  public String? Focus
  {
    get => (String?)OpenXmlElement?.Focus?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Focus = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Radial Gradient Size
  /// </summary>
  public String? FocusSize
  {
    get => (String?)OpenXmlElement?.FocusSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FocusSize = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Radial Gradient Center
  /// </summary>
  public String? FocusPosition
  {
    get => (String?)OpenXmlElement?.FocusPosition?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FocusPosition = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  public FillMethodKind? Method
  {
    get => (FillMethodKind?)OpenXmlElement?.Method?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Method = (DocumentFormat.OpenXml.Vml.FillMethodValues?)value;
    }
  }
  
  /// <summary>
  /// Detect Mouse Click
  /// </summary>
  public Boolean? DetectMouseClick
  {
    get => (Boolean?)OpenXmlElement?.DetectMouseClick?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DetectMouseClick = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Title
  /// </summary>
  public String? Title
  {
    get => (String?)OpenXmlElement?.Title?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Title = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Secondary Color Opacity
  /// </summary>
  public String? Opacity2
  {
    get => (String?)OpenXmlElement?.Opacity2?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Opacity2 = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Recolor Fill as Picture
  /// </summary>
  public Boolean? Recolor
  {
    get => (Boolean?)OpenXmlElement?.Recolor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Recolor = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Rotate Fill with Shape
  /// </summary>
  public Boolean? Rotate
  {
    get => (Boolean?)OpenXmlElement?.Rotate?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Rotate = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Relationship to Part
  /// </summary>
  public String? RelationshipId
  {
    get => (String?)OpenXmlElement?.RelationshipId?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RelationshipId = (System.String?)value;
    }
  }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  public FillExtendedProperties? FillExtendedProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
