namespace DocumentModel;

using DocumentModel.Utils;

using DX = DocumentFormat.OpenXml;
using DXCP = DocumentFormat.OpenXml.CustomProperties;
using DXVT = DocumentFormat.OpenXml.VariantTypes;

public class CustomProperty
{
  public CustomProperty(DXCP.CustomDocumentProperty property)
  {
    _property = property;
  }

  private DXCP.CustomDocumentProperty _property;

  public string? Name
  {
    get => _property.Name?.Value;
    set
    {
      if (value != null)
        _property.Name = value;
      else
        _property.Name = null;
    }
  }

  public int? Id
  {
    get => _property.PropertyId?.Value;
    set
    {
      if (value != null)
        _property.PropertyId = value;
      else
        _property.PropertyId = null;
    }
  }

  public Guid? FormatId
  {
    get => _property.FormatId?.AsGuid();
    set
    {
      if (value != null)
        _property.FormatId = value.ToString();
      else
        _property.FormatId = null;
    }
  }

  public string? LinkTarget
  {
    get => _property.LinkTarget?.Value;
    set
    {
      if (value != null)
        _property.LinkTarget = value;
      else
        _property.LinkTarget = null;
    }
  }

  public object? Value
  {
    get
    {
      var childItem = _property.ChildElements.FirstOrDefault();
      if (childItem!=null)
      {
        if (childItem is DXVT.VTVector vtVector)
          return vtVector.AsArray();
        if (childItem is DXVT.VTArray vtArray)
          return vtArray.AsArray();
        if (childItem is DX.OpenXmlLeafTextElement vtOther)
          return vtOther.AsObject();
      }
      return null;
    }
  }
}
