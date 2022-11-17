namespace DocumentModel.Vml;

public interface ITextBox // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public string? Id { get ; set; }

  public string? Style { get ; set; }

  public string? Inset { get ; set; }

  public ITrueFalseValue? SingleClick { get ; set; }

}
