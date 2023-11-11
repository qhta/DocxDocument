namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the parameters of a single document variable. 
/// A document variable is a storage location for arbitrary customer data in name/value pairs 
/// that is persisted in a given WordprocessingML document. Specifically, this element specifies 
/// through its name and val attributes the name and value pair for a given document variable.
/// [Note: This mechanism is maintained for legacy compatibility only, 
/// and should be avoided in favor of the custom XML data support defined in /IEC 29500. end note]
/// </summary>
[Obsolete]
[DataContract]
public partial class DocumentVariable: ModelElement<DXW.DocumentVariable>, INamedElement
{
  public DocumentVariable(): base(){ }

  public DocumentVariable(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public DocumentVariable(DXW.DocumentVariable openXmlElement): base(openXmlElement) { } 

  [DataMember]
  public string? Name
  {
    get => _Element?.Name?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Name = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.Name = null;
    }
  }

  [DataMember]
  public string? Val
  {
    get => _Element?.Val?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Val = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.Val = null;
    }
  }

}
