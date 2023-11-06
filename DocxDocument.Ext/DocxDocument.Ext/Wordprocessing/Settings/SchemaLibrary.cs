namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the set of XML namespaces which have been associated with the contents of the custom XML markup 
/// within the current Office Open XML document. Each unique namespace which is referenced within the document 
/// can be referenced within this element by a single schema element, regardless of the number of constituent XML schemas 
/// which comprise that namespace.
/// </summary>
public partial class SchemaLibrary: ModelElement<DXCXSR.SchemaLibrary>
{
  public SchemaLibrary(): base(){ }

  public SchemaLibrary(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public SchemaLibrary(DXCXSR.SchemaLibrary openXmlElement): base(openXmlElement) { } 
}
