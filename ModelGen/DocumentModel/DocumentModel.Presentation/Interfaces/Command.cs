namespace DocumentModel.Presentation;

/// <summary>
/// Command.
/// </summary>
public interface Command // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Command Type
  /// </summary>
  public CommandKind? Type { get ; set; }
  
  /// <summary>
  /// Command
  /// </summary>
  public String? CommandName { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public CommonBehavior? CommonBehavior { get ; set; }
  
}
