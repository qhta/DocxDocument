namespace DocumentModel.Vml;

/// <summary>
/// Defines the Fill Class.
/// </summary>
public interface Fill
{
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillKind? Type { get ; set; }
  
  /// <summary>
  /// Image Aspect Ratio
  /// </summary>
  public ImageAspectKind? Aspect { get ; set; }
  
  /// <summary>
  /// Gradient Fill Method
  /// </summary>
  public FillMethodKind? Method { get ; set; }
  
  /// <summary>
  /// FillExtendedProperties.
  /// </summary>
  public FillExtendedProperties? FillExtendedProperties { get ; set; }
  
}
