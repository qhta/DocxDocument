namespace DocumentModel.Presentation;

/// <summary>
/// Command.
/// </summary>
public interface ICommand // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Command Type
  /// </summary>
  public DocumentModel.Presentation.CommandKind? Type { get ; set; }
  
  /// <summary>
  /// Command
  /// </summary>
  public System.String? CommandName { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public DocumentModel.Presentation.ICommonBehavior? CommonBehavior { get ; set; }
  
}
