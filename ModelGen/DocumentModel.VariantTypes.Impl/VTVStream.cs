using System;
using System.IO;

using DocumentFormat.OpenXml.VariantTypes;

namespace DocumentModel.VariantTypes;

/// <summary>
/// VStream variant. Similar to Stream variant but with additional Version property
/// </summary>
public class VTVStreamImpl : VTStreamImpl, VTVStream
{
  public VTVStreamImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTVStreamData();
  }

  public VTVStreamImpl(DocumentFormat.OpenXml.VariantTypes.VTVStreamData element)
  {
    OpenXmlElement = element;
  }

  /// <summary>
  /// <para>VSTREAM Version Attribute</para>
  /// </summary>
  public Guid? Version
  {
    get
    {
      if (OpenXmlElement is VTVStreamData openXmlElement)
      {
        if (openXmlElement.Version?.Value != null)
          _version = Guid.Parse(openXmlElement.Version.Value);
        else
          _version = null;
      }
      return _version;
    }
    set
    {
      _version = value;
      if (OpenXmlElement is VTVStreamData openXmlElement)
      {
        if (value is Guid val)
          openXmlElement.Version = val.ToString("B");
        if (value is null)
          openXmlElement.Version = string.Empty;
      }
    }
  }
  private Guid? _version;
}

