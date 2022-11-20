namespace DocumentModel.EMMA;

/// <summary>
/// Defines the Arc Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.EMMA.IInfo))]
public class Arc: IArc
{
  /// <summary>
  /// from
  /// </summary>
  public int? From
  {
    get;
    set;
  }
  
  /// <summary>
  /// to
  /// </summary>
  public int? To
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
  /// confidence
  /// </summary>
  public decimal? Confidence
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
  /// lang
  /// </summary>
  public string? Language
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
  /// source
  /// </summary>
  public string? Source
  {
    get;
    set;
  }
  
}
