namespace DocumentModel.Office2010.PowerPoint;

public interface INonVisualDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? Id { get ; set; }

  public string? Name { get ; set; }

  public string? Description { get ; set; }

  public bool? Hidden { get ; set; }

  public string? Title { get ; set; }

  public IHyperlinkOnClick? HyperlinkOnClick { get ; set; }

  public IHyperlinkOnHover? HyperlinkOnHover { get ; set; }

  public INonVisualDrawingPropertiesExtensionList? NonVisualDrawingPropertiesExtensionList { get ; set; }

}
