namespace DocumentModel.Office2021.PowerPoint.Comment;

/// <summary>
/// Defines the TextBodyType Class.
/// </summary>
public interface ITextBodyType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public IBodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public IListStyle? ListStyle { get ; set; }
  
}
