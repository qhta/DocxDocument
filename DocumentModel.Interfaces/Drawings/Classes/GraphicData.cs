namespace DocumentModel.Drawings;

/// <summary>
///   Graphic Object Data.
/// </summary>
public interface GraphicData: IModelElement
{
  /// <summary>
  ///   Uniform Resource Identifier
  /// </summary>
  public string? Uri { get; set; }
}