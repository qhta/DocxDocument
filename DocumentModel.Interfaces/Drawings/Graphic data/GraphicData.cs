namespace DocumentModel.Drawings;

/// <summary>
///   Represents data for a graphic object, including its Uniform Resource Identifier.
/// </summary>
public interface GraphicData
{
  /// <summary>
  ///   Uniform Resource Identifier for the graphic object.
  /// </summary>
  public string? Uri { get; set; }
}