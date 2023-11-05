namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the properties associated with a single XML namespace, for which all known XML schemas 
/// shall be loaded in order to validate the custom XML markup stored within this document. 
/// These properties can be used appropriately to locate custom XML schema(s) for use with the document. 
/// /IEC 29500 does not require any particular XML schema language.
/// </summary>
[DataContract]
public partial class Schema: IOpenXmlElementMappedObject
{
  public Schema()
  {
    _Element = new DXCXSR.Schema();
  }

  public Schema(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXCXSR.Schema)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public Schema(DXCXSR.Schema openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXCXSR.Schema _Element { get; private set; }

  [DataMember]
  public string? Uri
  {
    get => _Element.Uri?.Value;
    set
    {
      if (value != null)
        _Element.Uri = new DX.StringValue { Value = (string)value };
      else
        _Element.Uri = null;
    }
  }

  [DataMember]
  public string? SchemaLocation
  {
    get => _Element.SchemaLocation?.Value;
    set
    {
      if (value != null)
        _Element.SchemaLocation = new DX.StringValue { Value = (string)value };
      else
        _Element.SchemaLocation = null;
    }
  }

  [DataMember]
  public string? ManifestLocation
  {
    get => _Element.ManifestLocation?.Value;
    set
    {
      if (value != null)
        _Element.ManifestLocation = new DX.StringValue { Value = (string)value };
      else
        _Element.ManifestLocation = null;
    }
  }
}
