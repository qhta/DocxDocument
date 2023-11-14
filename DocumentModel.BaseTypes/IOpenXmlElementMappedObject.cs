namespace DocumentModel;

/// <summary>
/// This interface must be implemented by model classes to produce an OpenXml element to be stored in OpenXml document.
/// </summary>
public interface IOpenXmlElementMappedObject
{
  /// <summary>
  /// Gets an OpenXml element of a desirable element type.
  /// If the type is not supported, the exception is thrown.
  /// </summary>
  /// <typeparam name="OpenXmlElementType"></typeparam>
  /// <returns></returns>
  public OpenXmlElementType? GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement;
}
