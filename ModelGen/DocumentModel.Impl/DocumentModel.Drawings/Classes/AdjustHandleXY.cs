namespace DocumentModel.Drawings;

/// <summary>
/// XY Adjust Handle.
/// </summary>
public class AdjustHandleXYImpl: ModelElementImpl, AdjustHandleXY
{
  public DocumentFormat.OpenXml.Drawing.AdjustHandleXY? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AdjustHandleXY?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AdjustHandleXYImpl(): base() {}
  
  public AdjustHandleXYImpl(DocumentFormat.OpenXml.Drawing.AdjustHandleXY openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Horizontal Adjustment Guide
  /// </summary>
  public String? XAdjustmentGuide
  {
    get => (String?)OpenXmlElement?.XAdjustmentGuide?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.XAdjustmentGuide = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Minimum Horizontal Adjustment
  /// </summary>
  public String? MinX
  {
    get => (String?)OpenXmlElement?.MinX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinX = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Maximum Horizontal Adjustment
  /// </summary>
  public String? MaxX
  {
    get => (String?)OpenXmlElement?.MaxX?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxX = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Vertical Adjustment Guide
  /// </summary>
  public String? YAdjustmentGuide
  {
    get => (String?)OpenXmlElement?.YAdjustmentGuide?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.YAdjustmentGuide = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Minimum Vertical Adjustment
  /// </summary>
  public String? MinY
  {
    get => (String?)OpenXmlElement?.MinY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinY = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Maximum Vertical Adjustment
  /// </summary>
  public String? MaxY
  {
    get => (String?)OpenXmlElement?.MaxY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxY = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public AdjustPoint2DType? Position
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
