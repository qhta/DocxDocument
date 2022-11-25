namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HyperlinkRuby Class.
/// </summary>
public interface IHyperlinkRuby // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// tgtFrame
  /// </summary>
  public System.String? TargetFrame { get ; set; }
  
  /// <summary>
  /// tooltip
  /// </summary>
  public System.String? Tooltip { get ; set; }
  
  /// <summary>
  /// docLocation
  /// </summary>
  public System.String? DocLocation { get ; set; }
  
  /// <summary>
  /// history
  /// </summary>
  public System.Boolean? History { get ; set; }
  
  /// <summary>
  /// anchor
  /// </summary>
  public System.String? Anchor { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public System.String? Id { get ; set; }
  
}
