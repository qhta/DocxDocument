namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifiesspecifies the presence of documentvariables in a WordprocessingML. 
/// A document variable is a storage location for arbitrary customer data in name/value pairs 
/// that is persisted in a given WordprocessingML document.
/// [Note: This mechanism is maintained for legacy compatibility only, and should be avoided 
/// in favor of the custom XML data support defined in /IEC 29500. end note]
/// </summary>
[Obsolete]
public partial class DocumentVariables: IOpenXmlElementMappedObject
{
  public DocumentVariables()
  {
    _Element = new DXW.DocumentVariables();
  }

  public DocumentVariables(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.DocumentVariables)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public DocumentVariables(DXW.DocumentVariables openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.DocumentVariables _Element { get; private set; }
}
