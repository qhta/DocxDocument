using DocumentModel.Wordprocessing;

namespace DocumentModel;

/// <summary>
/// Base class for element wrapping model.
/// </summary>
public class ModelElement<T> : ModelElement, IModelElement<T>
  where T: DX.OpenXmlElement
{

  /// <summary>
  /// Wrapped OpenXml element.
  /// </summary>
  public T Element { get; protected set; } = null!;

}
  