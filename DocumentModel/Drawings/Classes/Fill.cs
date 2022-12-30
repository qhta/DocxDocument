namespace DocumentModel.Drawings;

/// <summary>
/// Fill.
/// </summary>
public partial class Fill
{
  /// <summary>
  /// NoFill.
  /// </summary>
  public Boolean? NoFill { get; set; }
  
  /// <summary>
  /// SolidFill.
  /// </summary>
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  /// <summary>
  /// GradientFill.
  /// </summary>
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  /// <summary>
  /// BlipFill.
  /// </summary>
  public DocumentModel.Drawings.BlipFill? BlipFill { get; set; }
  
  /// <summary>
  /// Pattern Fill.
  /// </summary>
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  /// <summary>
  /// Group Fill.
  /// </summary>
  public Boolean? GroupFill { get; set; }
  
}
