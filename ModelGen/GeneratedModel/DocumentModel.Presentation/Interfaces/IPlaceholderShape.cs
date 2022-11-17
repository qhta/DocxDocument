namespace DocumentModel.Presentation;

public interface IPlaceholderShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public Placeholder? Type { get ; set; }

  public DocumentModel.Presentation.Direction? Orientation { get ; set; }

  public PlaceholderSize? Size { get ; set; }

  public uint? Index { get ; set; }

  public bool? HasCustomPrompt { get ; set; }

  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }

}
