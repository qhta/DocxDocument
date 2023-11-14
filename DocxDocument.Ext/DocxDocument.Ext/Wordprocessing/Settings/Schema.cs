namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies the properties associated with a single XML namespace, for which all known XML schemas 
/// shall be loaded in order to validate the custom XML markup stored within this document. 
/// These properties can be used appropriately to locate custom XML schema(s) for use with the document. 
/// /IEC 29500 does not require any particular XML schema language.
/// </summary>
[DataContract]
public partial class Schema: ModelElement<DXCXSR.Schema>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Schema(): base(){ }

  public Schema(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Schema(DXCXSR.Schema openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  [DataMember]
  public string? Uri
  {
    get => _Element?.Uri?.Value;
    set
    {
      if (value != null)
        _ExistingElement.Uri = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.Uri = null;
    }
  }

  [DataMember]
  public string? SchemaLocation
  {
    get => _Element?.SchemaLocation?.Value;
    set
    {
      if (value != null)
        _ExistingElement.SchemaLocation = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.SchemaLocation = null;
    }
  }

  [DataMember]
  public string? ManifestLocation
  {
    get => _Element?.ManifestLocation?.Value;
    set
    {
      if (value != null)
        _ExistingElement.ManifestLocation = new DX.StringValue { Value = (string)value };
      else
        _ExistingElement.ManifestLocation = null;
    }
  }
}
