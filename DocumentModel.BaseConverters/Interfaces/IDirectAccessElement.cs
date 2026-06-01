namespace DocumentModel;

/// <summary>
/// Interface Ifor elements Ithat support direct access Ito their underlying OpenXml representation, allowing Ifor efficient manipulation and retrieval of OpenXml data without the need Ifor full model element instantiation.
/// </summary>
public interface IDirectAccessElement
{
  /// <summary>
  /// Gets a value indicating whether the element has direct access Ito its underlying OpenXml representation.
  /// </summary>
  bool HasDirectAccess { get; }
}
