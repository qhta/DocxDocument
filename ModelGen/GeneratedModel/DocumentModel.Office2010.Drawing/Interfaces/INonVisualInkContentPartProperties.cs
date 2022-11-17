namespace DocumentModel.Office2010.Drawing;

public interface INonVisualInkContentPartProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? IsComment { get ; set; }

  public IContentPartLocks? ContentPartLocks { get ; set; }

  public DocumentModel.Office2010.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }

}
