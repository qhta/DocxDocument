namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifiesspecifies the presence of documentvariables in a WordprocessingML. 
/// A document variable is a storage location for arbitrary customer data in name/value pairs 
/// that is persisted in a given WordprocessingML document.
/// [Note: This mechanism is maintained for legacy compatibility only, and should be avoided 
/// in favor of the custom XML data support defined in /IEC 29500. end note]
/// </summary>
[Obsolete]
public partial class DocumentVariables: ModelElement<DXW.DocumentVariables>
{
  public DocumentVariables(): base(){ }

  public DocumentVariables(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public DocumentVariables(DXW.DocumentVariables openXmlElement): base(openXmlElement) { } 
}
