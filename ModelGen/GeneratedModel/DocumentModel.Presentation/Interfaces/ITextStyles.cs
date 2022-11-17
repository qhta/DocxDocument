namespace DocumentModel.Presentation;

public interface ITextStyles // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Presentation.ITitleStyle? TitleStyle { get ; set; }

  public IBodyStyle? BodyStyle { get ; set; }

  public IOtherStyle? OtherStyle { get ; set; }

  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }

}
