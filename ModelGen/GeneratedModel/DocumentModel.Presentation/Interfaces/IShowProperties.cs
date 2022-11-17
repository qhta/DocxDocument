namespace DocumentModel.Presentation;

public interface IShowProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? Loop { get ; set; }

  public bool? ShowNarration { get ; set; }

  public bool? ShowAnimation { get ; set; }

  public bool? UseTimings { get ; set; }

}
