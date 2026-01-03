namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the RadarSerExtensionList Class.
/// </summary>
public interface RadarSerExtensionList: IModelElement
{
  public Collection<RadarSerExtension>? RadarSerExtensions { get; set; }
}