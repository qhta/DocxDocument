namespace DocumentModel.Spreadsheet;

public interface IControlProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Locked { get ; set; }
  
  public bool? DefaultSize { get ; set; }
  
  public bool? Print { get ; set; }
  
  public bool? Disabled { get ; set; }
  
  public bool? RecalcAlways { get ; set; }
  
  public bool? UiObject { get ; set; }
  
  public bool? AutoFill { get ; set; }
  
  public bool? AutoLine { get ; set; }
  
  public bool? AutoPict { get ; set; }
  
  public string? Macro { get ; set; }
  
  public string? AltText { get ; set; }
  
  public string? LinkedCell { get ; set; }
  
  public string? ListFillRange { get ; set; }
  
  public string? Cf { get ; set; }
  
  public string? Id { get ; set; }
  
  public IObjectAnchor? ObjectAnchor { get ; set; }
  
}
