namespace DocumentModel.Presentation;

public interface IIterate // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public Iterate? Type { get ; set; }

  public bool? Backwards { get ; set; }

  public ITimeAbsolute? TimeAbsolute { get ; set; }

  public ITimePercentage? TimePercentage { get ; set; }

}
