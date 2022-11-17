namespace DocumentModel.Vml;

public interface IShadow // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public string? Id { get ; set; }

  public ITrueFalseValue? On { get ; set; }

  public Shadow? Type { get ; set; }

  public ITrueFalseValue? Obscured { get ; set; }

  public string? Color { get ; set; }

  public string? Opacity { get ; set; }

  public string? Offset { get ; set; }

  public string? Color2 { get ; set; }

  public string? Offset2 { get ; set; }

  public string? Origin { get ; set; }

  public string? Matrix { get ; set; }

}
