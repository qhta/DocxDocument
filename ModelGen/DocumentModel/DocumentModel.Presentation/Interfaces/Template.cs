namespace DocumentModel.Presentation;

/// <summary>
/// Template Effects.
/// </summary>
public interface Template // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Level
  /// </summary>
  public UInt32? Level { get ; set; }
  
  /// <summary>
  /// Time Node List.
  /// </summary>
  public TimeNodeList? TimeNodeList { get ; set; }
  
}
