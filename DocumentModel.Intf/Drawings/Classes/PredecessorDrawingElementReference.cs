namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PredecessorDrawingElementReference Class.
/// </summary>
public class PredecessorDrawingElementReference: ModelElement
{
  /// <summary>
  ///   pred, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Pred { get; set; }
}