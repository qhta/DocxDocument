namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPhotocopy Class.
/// </summary>
public class ArtisticPhotocopy: ModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   detail, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Detail { get; set; }
}