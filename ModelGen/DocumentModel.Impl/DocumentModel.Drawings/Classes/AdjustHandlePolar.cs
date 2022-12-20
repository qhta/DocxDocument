namespace DocumentModel.Drawings;

/// <summary>
/// Polar Adjust Handle.
/// </summary>
public partial class AdjustHandlePolarImpl: ModelElementImpl, AdjustHandlePolar
{
  public DocumentFormat.OpenXml.Drawing.AdjustHandlePolar? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.AdjustHandlePolar?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public AdjustHandlePolarImpl(): base() {}
  
  public AdjustHandlePolarImpl(DocumentFormat.OpenXml.Drawing.AdjustHandlePolar openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Radial Adjustment Guide
  /// </summary>
  public String? RadialAdjustmentGuide
  {
    get => (System.String?)OpenXmlElement?.RadialAdjustmentGuide?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.RadialAdjustmentGuide = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Minimum Radial Adjustment
  /// </summary>
  public String? MinRadial
  {
    get => (System.String?)OpenXmlElement?.MinRadial?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinRadial = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Maximum Radial Adjustment
  /// </summary>
  public String? MaxRadial
  {
    get => (System.String?)OpenXmlElement?.MaxRadial?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxRadial = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Angle Adjustment Guide
  /// </summary>
  public String? AngleAdjustmentGuide
  {
    get => (System.String?)OpenXmlElement?.AngleAdjustmentGuide?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.AngleAdjustmentGuide = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Minimum Angle Adjustment
  /// </summary>
  public String? MinAngle
  {
    get => (System.String?)OpenXmlElement?.MinAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MinAngle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Maximum Angle Adjustment
  /// </summary>
  public String? MaxAngle
  {
    get => (System.String?)OpenXmlElement?.MaxAngle?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.MaxAngle = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shape Position Coordinate.
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
