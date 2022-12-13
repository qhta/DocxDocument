namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Outline Class.
/// </summary>
public interface Outline
{
  public Boolean? NoFill { get ; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get ; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get ; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get ; set; }
  
  public DocumentModel.Drawings.PresetLineDashKind? PresetDash { get ; set; }
  
  public DocumentModel.Drawings.CustomDash? CustomDash { get ; set; }
  
  public Boolean? Round { get ; set; }
  
  public Boolean? LineJoinBevel { get ; set; }
  
  public DocumentModel.Drawings.Miter? Miter { get ; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? HeadEnd { get ; set; }
  
  public DocumentModel.Drawings.LineEndPropertiesType? TailEnd { get ; set; }
  
  public DocumentModel.Drawings.LinePropertiesExtensionList? LinePropertiesExtensionList { get ; set; }
  
}
