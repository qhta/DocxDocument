namespace DocumentModel.Presentation;

public interface IBlipFill // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? Dpi { get ; set; }

  public bool? RotateWithShape { get ; set; }

  public DocumentModel.Drawing.IBlip? Blip { get ; set; }

  public ISourceRectangle? SourceRectangle { get ; set; }

}
