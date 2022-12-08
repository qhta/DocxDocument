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
  
  /// <summary>
  /// Name
  /// </summary>
  public String? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Axis
  /// </summary>
  public List<AxisKind>? Axis
  {
    get;
    set;
  }
  
  /// <summary>
  /// Data Point Type
  /// </summary>
  public List<ElementKind>? PointType
  {
    get;
    set;
  }
  
  /// <summary>
  /// Hide Last Transition
  /// </summary>
  public List<Boolean>? HideLastTrans
  {
    get;
    set;
  }
  
  /// <summary>
  /// Start
  /// </summary>
  public List<Int32>? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// Count
  /// </summary>
  public List<UInt32>? Count
  {
    get;
    set;
  }
  
  /// <summary>
  /// Step
  /// </summary>
  public List<Int32>? Step
  {
    get;
    set;
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
    get;
    set;
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
    get;
    set;
  }
  
  public Collection<Algorithm>? Algorithms
  {
    get;
    set;
  }
  
  public Collection<Shape4>? Shapes
  {
    get;
    set;
  }
  
  public Collection<PresentationOf>? PresentationOfs
  {
    get;
    set;
  }
  
  public Collection<Constraints>? Constraintses
  {
    get;
    set;
  }
  
  public Collection<RuleList>? RuleLists
  {
    get;
    set;
  }
  
  public Collection<ForEach>? ForEachs
  {
    get;
    set;
  }
  
  public Collection<LayoutNode>? LayoutNodes
  {
    get;
    set;
  }
  
  public Collection<Choose>? Chooses
  {
    get;
    set;
  }
  
  public Collection<ExtensionList3>? ExtensionLists
  {
    get;
    set;
  }
  
}
