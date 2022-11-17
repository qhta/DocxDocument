namespace DocumentModel.Vml.Office;

public interface ISkew // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public ExtensionHandlingBehavior? Extension { get ; set; }

  public string? Id { get ; set; }

  public ITrueFalseValue? On { get ; set; }

  public string? Offset { get ; set; }

  public string? Origin { get ; set; }

  public string? Matrix { get ; set; }

}
