namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ParentLabelLayout Class.
/// </summary>
public class ParentLabelLayout: ModelElement
{
  /// <summary>
  ///   val, this property is only available in Office 2016 and later.
  /// </summary>
  public ParentLabelLayoutVal? ParentLabelLayoutVal { get; set; }
}