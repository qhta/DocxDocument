namespace DocumentModel.Drawings;


/// <summary>
///   Underline Stroke.
/// </summary>
public partial class Underline
{
  public DocumentModel.Drawings.NoFill? NoFill { get; set; }
  
  public DocumentModel.Drawings.SolidFill? SolidFill { get; set; }
  
  public DocumentModel.Drawings.GradientFill? GradientFill { get; set; }
  
  public DocumentModel.Drawings.PatternFill? PatternFill { get; set; }
  
  public DocumentModel.Drawings.PresetLineDashKind? PresetDash { get; set; }
  
  public DocumentModel.Drawings.CustomDash? CustomDash { get; set; }
  
  public DocumentModel.Drawings.Round? Round { get; set; }
  
  public DocumentModel.Drawings.LineJoinBevel? LineJoinBevel { get; set; }
  
  public DocumentModel.Drawings.Miter? Miter { get; set; }
  
  public DocumentModel.Drawings.HeadEnd? HeadEnd { get; set; }
  
  public DocumentModel.Drawings.TailEnd? TailEnd { get; set; }
  
  public DocumentModel.Drawings.LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
  
}
