namespace DocumentModel.Spreadsheet;

public interface IDrawingHeaderFooter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Id { get ; set; }
  
  public uint? Lho { get ; set; }
  
  public uint? Lhe { get ; set; }
  
  public uint? Lhf { get ; set; }
  
  public uint? Cho { get ; set; }
  
  public uint? Che { get ; set; }
  
  public uint? Chf { get ; set; }
  
  public uint? Rho { get ; set; }
  
  public uint? Rhe { get ; set; }
  
  public uint? Rhf { get ; set; }
  
  public uint? Lfo { get ; set; }
  
  public uint? Lfe { get ; set; }
  
  public uint? Lff { get ; set; }
  
  public uint? Cfo { get ; set; }
  
  public uint? Cfe { get ; set; }
  
  public uint? Cff { get ; set; }
  
  public uint? Rfo { get ; set; }
  
  public uint? Rfe { get ; set; }
  
  public uint? Rff { get ; set; }
  
}
