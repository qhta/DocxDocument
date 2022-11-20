namespace DocumentModel.Presentation;

/// <summary>
/// Command.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
public class Command: ICommand
{
  /// <summary>
  /// Command Type
  /// </summary>
  public CommandValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Command
  /// </summary>
  public string? CommandName
  {
    get;
    set;
  }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior
  {
    get;
    set;
  }
  
}
