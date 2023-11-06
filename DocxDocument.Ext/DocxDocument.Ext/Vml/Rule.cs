namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a rule entry in a rules element rule set that describes how a certain shape or set of shapes behaves during editing.
/// </summary>
public partial class Rule : ModelElement<DXVO.Rule>
{
  public Rule(): base(){ }

  public Rule(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Rule(DXVO.Rule openXmlElement): base(openXmlElement) { } 

  /// <summary>
  /// Specifies an identifier for the rule. Default is no value.
  /// </summary>
  [DataMember]
  public string? Id
  {
    get => _Element.Id?.Value;
    set => _Element.Id = value;
  }

  /// <summary>
  /// Specifies the kind of the rule. Default is no value. Allowed values are:
  /// <list type="bullet">
  ///   <item>arc</item>
  ///   <item>callout</item>
  ///   <item>connector</item>
  ///   <item>align</item>
  /// </list>
  /// </summary>
  [DataMember]
  public DXVO.RuleValues? Type
  {
    get => _Element.Type?.Value;
    set => _Element.Type = value;
  }

  /// <summary>
  /// Specifies a reference to a shape in the current document that is the primary shape in the rule. 
  /// [Example: For a connector rule, the connector. end example]
  /// Default is no value. A shape name is used as the reference mechanism; this is not a relationship ID.
  /// </summary>
  [DataMember]
  public string? ShapeReference
  {
    get => _Element.ShapeReference?.Value;
    set => _Element.ShapeReference = value;
  }

  [DataMember]
  public DXVO.AlignmentValues? How
  {
    get => _Element.How?.Value;
    set => _Element.How = value;
  }
}
