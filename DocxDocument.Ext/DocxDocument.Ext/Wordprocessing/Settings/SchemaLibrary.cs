namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the set of XML namespaces which have been associated with the contents of the custom XML markup 
/// within the current Office Open XML document. Each unique namespace which is referenced within the document 
/// can be referenced within this element by a single schema element, regardless of the number of constituent XML schemas 
/// which comprise that namespace.
/// </summary>
public partial class SchemaLibrary: IOpenXmlElementMappedObject
{
  public SchemaLibrary()
  {
    _Element = new DXCXSR.SchemaLibrary();
  }

  public SchemaLibrary(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXCXSR.SchemaLibrary)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public SchemaLibrary(DXCXSR.SchemaLibrary openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXCXSR.SchemaLibrary _Element { get; private set; }
}
