namespace DocumentModel;

/// <summary>
/// Interface for elements that support direct access to their underlying OpenXml representation, allowing for efficient manipulation and retrieval of OpenXml data without the need for full model element instantiation.
/// </summary>
public interface IDirectAccessElement
{
  /// <summary>
  /// Gets a value indicating whether the element has direct access to its underlying OpenXml representation.
  /// </summary>
  bool HasDirectAccess { get; }
}
