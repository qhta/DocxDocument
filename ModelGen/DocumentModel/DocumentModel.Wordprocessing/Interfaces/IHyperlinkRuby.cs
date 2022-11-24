namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the HyperlinkRuby Class.
/// </summary>
public interface IHyperlinkRuby // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// tgtFrame
  /// </summary>
  public String? TargetFrame { get ; set; }
  
  /// <summary>
  /// tooltip
  /// </summary>
  public String? Tooltip { get ; set; }
  
  /// <summary>
  /// docLocation
  /// </summary>
  public String? DocLocation { get ; set; }
  
  /// <summary>
  /// history
  /// </summary>
  public Boolean? History { get ; set; }
  
  /// <summary>
  /// anchor
  /// </summary>
  public String? Anchor { get ; set; }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get ; set; }
  
}
