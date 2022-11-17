namespace DocumentModel.Spreadsheet;

public interface IDataBinding // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? DataBindingName { get ; set; }
  
  public bool? FileBinding { get ; set; }
  
  public uint? ConnectionId { get ; set; }
  
  public string? FileBindingName { get ; set; }
  
  public uint? DataBindingLoadMode { get ; set; }
  
}
