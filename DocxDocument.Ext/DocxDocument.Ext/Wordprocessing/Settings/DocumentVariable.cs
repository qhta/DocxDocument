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
public partial class DocumentVariable: IOpenXmlElementMappedObject
{
  public DocumentVariable()
  {
    _Element = new DXW.DocumentVariable();
  }

  public DocumentVariable(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.DocumentVariable)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public DocumentVariable(DXW.DocumentVariable openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.DocumentVariable _Element { get; private set; }

  [DataMember]
  public String? Name
  {
    get => _Element.Name?.Value;
    set
    {
      if (value != null)
        _Element.Name = new DX.StringValue { Value = (string)value };
      else
        _Element.Name = null;
    }
  }

  [DataMember]
  public String? Val
  {
    get => _Element.Val?.Value;
    set
    {
      if (value != null)
        _Element.Val = new DX.StringValue { Value = (string)value };
      else
        _Element.Val = null;
    }
  }

}
