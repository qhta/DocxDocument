namespace DocumentModel.Vml;

/// <summary>
/// Shape Handle.
/// </summary>
public class ShapeHandleImpl: ModelElementImpl, ShapeHandle
{
  public DocumentFormat.OpenXml.Vml.ShapeHandle? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.ShapeHandle?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ShapeHandleImpl(): base() {}
  
  public ShapeHandleImpl(DocumentFormat.OpenXml.Vml.ShapeHandle openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Handle Position
  /// </summary>
  public String? Position
  {
    get => (System.String?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Handle Polar Center
  /// </summary>
  public String? Polar
  {
    get => (System.String?)OpenXmlElement?.Polar?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Polar = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Handle Coordinate Mapping
  /// </summary>
  public String? Map
  {
    get => (System.String?)OpenXmlElement?.Map?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Map = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Invert Handle's X Position
  /// </summary>
  public Boolean? InvertX
  {
    get => (System.Boolean?)OpenXmlElement?.InvertX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InvertX = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Invert Handle's Y Position
  /// </summary>
  public Boolean? InvertY
  {
    get => (System.Boolean?)OpenXmlElement?.InvertY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InvertY = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Handle Inversion Toggle
  /// </summary>
  public Boolean? Switch
  {
    get => (System.Boolean?)OpenXmlElement?.Switch?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Switch = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Handle X Position Range
  /// </summary>
  public String? XRange
  {
    get => (System.String?)OpenXmlElement?.XRange?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.XRange = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Handle Y Position Range
  /// </summary>
  public String? YRange
  {
    get => (System.String?)OpenXmlElement?.YRange?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.YRange = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Handle Polar Radius Range
  /// </summary>
  public String? RadiusRange
  {
    get => (System.String?)OpenXmlElement?.RadiusRange?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RadiusRange = (System.String?)value;
    }
  }
  
}
