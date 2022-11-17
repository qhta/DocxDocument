namespace DocumentModel.Presentation;

public interface ITransition // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public TransitionSpeed? Speed { get ; set; }

  public string? Duration { get ; set; }

  public bool? AdvanceOnClick { get ; set; }

  public string? AdvanceAfterTime { get ; set; }

}
