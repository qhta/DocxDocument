namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the ParentLabelLayout Class.
/// </summary>
public interface ParentLabelLayout: IModelElement
{
  /// <summary>
  ///   val
  /// </summary>
  public ParentLabelLayoutVal? ParentLabelLayoutVal { get; set; }
}