namespace DocumentModel.Presentation;

/// <summary>
/// Command.
/// </summary>
public interface ICommand // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Command Type
  /// </summary>
  public CommandValues? Type { get ; set; }
  
  /// <summary>
  /// Command
  /// </summary>
  public String? CommandName { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
}
