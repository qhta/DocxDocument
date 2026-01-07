namespace DocumentModel.Drawings;

/// <summary>
///   Represents properties for an embedded object, including its identifier, ActiveX status, and link type.
/// </summary>
public interface ObjectProperties
{
  /// <summary>
  ///   Identifier for the embedded object.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   Indicates whether the object is an ActiveX control.
  /// </summary>
  public bool? IsActiveX { get; set; }

  /// <summary>
  ///   Type of link associated with the object.
  /// </summary>
  public string? LinkType { get; set; }
}