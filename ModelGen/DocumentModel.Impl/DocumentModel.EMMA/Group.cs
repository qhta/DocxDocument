namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Group Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IDerivedFrom))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IGroup))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IGroupInfo))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IInfo))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IInterpretation))]
[ChildElementInfo(typeof(DocumentModel.EMMA.IOneOf))]
[ChildElementInfo(typeof(DocumentModel.EMMA.ISequence))]
public class Group: IGroup
{
  /// <summary>
  /// id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// tokens
  /// </summary>
  public string? Tokens
  {
    get;
    set;
  }
  
  /// <summary>
  /// process
  /// </summary>
  public string? Process
  {
    get;
    set;
  }
  
  /// <summary>
  /// lang
  /// </summary>
  public string? Language
  {
    get;
    set;
  }
  
  /// <summary>
  /// signal
  /// </summary>
  public string? Signal
  {
    get;
    set;
  }
  
  /// <summary>
  /// signal-size
  /// </summary>
  public int? SignalSize
  {
    get;
    set;
  }
  
  /// <summary>
  /// media-type
  /// </summary>
  public string? MediaType
  {
    get;
    set;
  }
  
  /// <summary>
  /// confidence
  /// </summary>
  public decimal? Confidence
  {
    get;
    set;
  }
  
  /// <summary>
  /// source
  /// </summary>
  public string? Source
  {
    get;
    set;
  }
  
  /// <summary>
  /// start
  /// </summary>
  public ulong? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// end
  /// </summary>
  public ulong? End
  {
    get;
    set;
  }
  
  /// <summary>
  /// time-ref-uri
  /// </summary>
  public string? TimeReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// time-ref-anchor-point
  /// </summary>
  public AnchorPointValues? TimeReferenceAnchorPoint
  {
    get;
    set;
  }
  
  /// <summary>
  /// offset-to-start
  /// </summary>
  public int? OffsetToStart
  {
    get;
    set;
  }
  
  /// <summary>
  /// duration
  /// </summary>
  public int? Duration
  {
    get;
    set;
  }
  
  /// <summary>
  /// medium
  /// </summary>
  public List<MediumValues>? Medium
  {
    get;
    set;
  }
  
  /// <summary>
  /// mode
  /// </summary>
  public List<string>? Mode
  {
    get;
    set;
  }
  
  /// <summary>
  /// function
  /// </summary>
  public string? Function
  {
    get;
    set;
  }
  
  /// <summary>
  /// verbal
  /// </summary>
  public bool? Verbal
  {
    get;
    set;
  }
  
  /// <summary>
  /// cost
  /// </summary>
  public decimal? Cost
  {
    get;
    set;
  }
  
  /// <summary>
  /// grammar-ref
  /// </summary>
  public string? GrammarRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// endpoint-info-ref
  /// </summary>
  public string? EndpointInfoRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// model-ref
  /// </summary>
  public string? ModelRef
  {
    get;
    set;
  }
  
  /// <summary>
  /// dialog-turn
  /// </summary>
  public string? DialogTurn
  {
    get;
    set;
  }
  
}
