namespace DocumentModel.Office2010.CustomUI;

public interface IButtonRegular // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? OnAction { get ; set; }
  
  public bool? Enabled { get ; set; }
  
  public string? GetEnabled { get ; set; }
  
  public string? Description { get ; set; }
  
  public string? GetDescription { get ; set; }
  
  public string? Image { get ; set; }
  
  public string? ImageMso { get ; set; }
  
  public string? GetImage { get ; set; }
  
  public string? Id { get ; set; }
  
  public string? QualifiedId { get ; set; }
  
  public string? Tag { get ; set; }
  
  public string? IdMso { get ; set; }
  
  public string? Screentip { get ; set; }
  
  public string? GetScreentip { get ; set; }
  
  public string? Supertip { get ; set; }
  
  public string? GetSupertip { get ; set; }
  
  public string? Label { get ; set; }
  
  public string? GetLabel { get ; set; }
  
  public string? InsertAfterMso { get ; set; }
  
  public string? InsertBeforeMso { get ; set; }
  
  public string? InsertAfterQulifiedId { get ; set; }
  
  public string? InsertBeforeQulifiedId { get ; set; }
  
  public bool? Visible { get ; set; }
  
  public string? GetVisible { get ; set; }
  
  public string? Keytip { get ; set; }
  
  public string? GetKeytip { get ; set; }
  
  public bool? ShowLabel { get ; set; }
  
  public string? GetShowLabel { get ; set; }
  
  public bool? ShowImage { get ; set; }
  
  public string? GetShowImage { get ; set; }
  
}
