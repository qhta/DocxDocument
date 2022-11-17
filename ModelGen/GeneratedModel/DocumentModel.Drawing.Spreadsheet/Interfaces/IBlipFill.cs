namespace DocumentModel.Drawing.Spreadsheet;

public interface IBlipFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? RotateWithShape { get ; set; }
  
  public DocumentModel.Drawing.IBlip? Blip { get ; set; }
  
  public ISourceRectangle? SourceRectangle { get ; set; }
  
}
