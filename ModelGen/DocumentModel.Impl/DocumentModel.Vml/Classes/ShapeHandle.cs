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
  
  /// <summary>
  /// Handle Position
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
  /// Handle Polar Center
  /// </summary>
  public String? Polar
  {
    get => (String?)OpenXmlElement?.Polar?.Value;
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
    get => (String?)OpenXmlElement?.Map?.Value;
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
    get => (Boolean?)OpenXmlElement?.InvertX?.Value;
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
    get => (Boolean?)OpenXmlElement?.InvertY?.Value;
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
    get => (Boolean?)OpenXmlElement?.Switch?.Value;
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
    get => (String?)OpenXmlElement?.XRange?.Value;
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
    get => (String?)OpenXmlElement?.YRange?.Value;
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
    get => (String?)OpenXmlElement?.RadiusRange?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RadiusRange = (System.String?)value;
    }
  }
  
}
