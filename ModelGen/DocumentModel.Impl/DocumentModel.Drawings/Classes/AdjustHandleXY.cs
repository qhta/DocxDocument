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
    get => (System.String?)OpenXmlElement?.XAdjustmentGuide?.Value;
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
    get => (System.String?)OpenXmlElement?.MinX?.Value;
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
    get => (System.String?)OpenXmlElement?.MaxX?.Value;
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
    get => (System.String?)OpenXmlElement?.YAdjustmentGuide?.Value;
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
    get => (System.String?)OpenXmlElement?.MinY?.Value;
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
    get => (System.String?)OpenXmlElement?.MaxY?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxY = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Position.
  /// </summary>
  public DocumentModel.Drawings.AdjustPoint2DType? Position
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustPoint2DType>();
        if (item != null)
          return new DocumentModel.Drawings.AdjustPoint2DTypeImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.AdjustPoint2DType>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Drawings.AdjustPoint2DTypeImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
