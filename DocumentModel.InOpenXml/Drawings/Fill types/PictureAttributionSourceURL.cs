namespace DocumentModel.Drawings;
/// <summary>
///   Represents a picture attribution source URL, providing an identifier for the attribution source.
/// </summary>
public partial class PictureAttributionSourceURL : ModelElement<DXO19D.PictureAttributionSourceURL>
{
  /// <summary>
  ///   Identifier for the picture attribution source.
  /// </summary>
  public string? Id { get; set; }
}