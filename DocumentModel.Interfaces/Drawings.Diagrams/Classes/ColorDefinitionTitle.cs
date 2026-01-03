namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Title.
/// </summary>
public interface ColorDefinitionTitle: IModelElement
{
  /// <summary>
  ///   Language
  /// </summary>
  public string? Language { get; set; }
  /// <summary>
  ///   Description Value
  /// </summary>
  public string? Val { get; set; }
}