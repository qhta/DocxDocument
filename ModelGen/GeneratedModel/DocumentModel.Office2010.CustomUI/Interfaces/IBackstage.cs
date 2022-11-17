namespace DocumentModel.Office2010.CustomUI;

public interface IBackstage // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? OnShow { get ; set; }
  
  public string? OnHide { get ; set; }
  
}
