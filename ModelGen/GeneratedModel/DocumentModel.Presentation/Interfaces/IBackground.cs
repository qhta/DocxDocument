namespace DocumentModel.Presentation;

public interface IBackground // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public BlackWhiteMode? BlackWhiteMode { get ; set; }

  public DocumentModel.Presentation.IBackgroundProperties? BackgroundProperties { get ; set; }

  public IBackgroundStyleReference? BackgroundStyleReference { get ; set; }

}
