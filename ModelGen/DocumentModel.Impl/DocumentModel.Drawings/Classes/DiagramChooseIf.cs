namespace DocumentModel.Drawings;

/// <summary>
/// If.
/// </summary>
public class DiagramChooseIfImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf>, DiagramChooseIf
{
  /// <summary>
  /// Function
  /// </summary>
  public FunctionKind? Function
  {
    get => (FunctionKind?)OpenXmlElement?.Function?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Function = (DocumentFormat.OpenXml.Drawing.Diagrams.FunctionValues?)value;
    }
  }
  
  /// <summary>
  /// Operator
  /// </summary>
  public FunctionOperatorKind? Operator
  {
    get => (FunctionOperatorKind?)OpenXmlElement?.Operator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Operator = (DocumentFormat.OpenXml.Drawing.Diagrams.FunctionOperatorValues?)value;
    }
  }
  
}
