namespace DocumentModel.Presentation;

public interface ISlideSize // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public int? Cx { get ; set; }

  public int? Cy { get ; set; }

  public SlideSize? Type { get ; set; }

}
