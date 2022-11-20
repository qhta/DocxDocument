namespace DocumentModel.Presentation;

/// <summary>
/// Defines the Iterate Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimePercentage))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITimeAbsolute))]
public class Iterate: IIterate
{
  /// <summary>
  /// Iterate Type
  /// </summary>
  public IterateValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Backwards
  /// </summary>
  public bool? Backwards
  {
    get;
    set;
  }
  
  /// <summary>
  /// Time Absolute.
  /// </summary>
  public ITimeAbsolute? TimeAbsolute
  {
    get;
    set;
  }
  
  /// <summary>
  /// Time Percentage.
  /// </summary>
  public ITimePercentage? TimePercentage
  {
    get;
    set;
  }
  
}
