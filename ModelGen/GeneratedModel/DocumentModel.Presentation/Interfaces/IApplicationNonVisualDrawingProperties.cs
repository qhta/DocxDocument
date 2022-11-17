namespace DocumentModel.Presentation;

public interface IApplicationNonVisualDrawingProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? IsPhoto { get ; set; }

  public bool? UserDrawn { get ; set; }

  public IPlaceholderShape? PlaceholderShape { get ; set; }

}
