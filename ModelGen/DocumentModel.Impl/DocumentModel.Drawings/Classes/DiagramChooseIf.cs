namespace DocumentModel.Drawings;

/// <summary>
/// If.
/// </summary>
public class DiagramChooseIfImpl: ModelElementImpl, DiagramChooseIf
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public DiagramChooseIfImpl(): base() {}
  
  public DiagramChooseIfImpl(DocumentFormat.OpenXml.Drawing.Diagrams.DiagramChooseIf openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get => (String?)OpenXmlElement?.Name?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Name = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<AxisKind>? Axis
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<ElementKind>? PointType
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<Boolean>? HideLastTrans
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<Int32>? Start
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<UInt32>? Count
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<Int32>? Step
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
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
  /// Argument
  /// </summary>
  public String? Argument
  {
    get => (String?)OpenXmlElement?.Argument?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Argument = (System.String?)value;
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
  
  /// <summary>
  /// Value
  /// </summary>
  public String? Val
  {
    get => (String?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (System.String?)value;
    }
  }
  
  public Algorithm? Algorithm
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Shape? Shape
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public PresentationOf? PresentationOf
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Constraints? Constraints
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public RuleList? RuleList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ForEach? ForEach
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public LayoutNode? LayoutNode
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public Choose? Choose
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
