namespace DocumentModel.Presentation;

/// <summary>
/// Command.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonBehavior))]
public interface ICommand // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Command Type
  /// </summary>
  public Command? Type { get ; set; }
  
  /// <summary>
  /// Command
  /// </summary>
  public string? CommandName { get ; set; }
  
  /// <summary>
  /// CommonBehavior.
  /// </summary>
  public ICommonBehavior? CommonBehavior { get ; set; }
  
}
