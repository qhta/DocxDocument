namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Hyperlink Class.
/// </summary>
public interface IHyperlink // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Hyperlink Target Frame
  /// </summary>
  public System.String? TargetFrame { get ; set; }
  
  /// <summary>
  /// Associated String
  /// </summary>
  public System.String? Tooltip { get ; set; }
  
  /// <summary>
  /// Location in Target Document
  /// </summary>
  public System.String? DocLocation { get ; set; }
  
  /// <summary>
  /// Add To Viewed Hyperlinks
  /// </summary>
  public System.Boolean? History { get ; set; }
  
  /// <summary>
  /// Hyperlink Anchor
  /// </summary>
  public System.String? Anchor { get ; set; }
  
  /// <summary>
  /// Hyperlink Target
  /// </summary>
  public System.String? Id { get ; set; }
  
}
