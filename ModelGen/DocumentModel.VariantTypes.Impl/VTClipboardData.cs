using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Clipboard Data variant. Value is of byte[] type. Has additional properties.
/// </summary>
public class VTClipboardDataImpl: VTBlobImpl, VTClipboardData
{
  public VTClipboardDataImpl()
  {
    OpenXmlElement = new DocumentFormat.OpenXml.VariantTypes.VTClipboardData();
  }

  public VTClipboardDataImpl(DocumentFormat.OpenXml.VariantTypes.VTClipboardData element)
  {
    OpenXmlElement = element;
  }

  public new DocumentFormat.OpenXml.VariantTypes.VTClipboardData? OpenXmlElement
  {
    get => base.OpenXmlElement as DocumentFormat.OpenXml.VariantTypes.VTClipboardData;
    set => base.OpenXmlElement = value;
  }

  /// <summary>
  /// <para>Format Attribute</para>
  /// </summary>
  public Int32? Format
  {
    get => (OpenXmlElement?.Format?.Value != null) ? OpenXmlElement.Format.Value : _format;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Format = value;
      _format = value;
    }
  }
  private int? _format = 0;

  /// <summary>
  /// <para>size</para>
  /// </summary>
  public UInt32? Size
  {
    get => (OpenXmlElement?.Size?.Value != null) ? OpenXmlElement.Size.Value : _size;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Size = value;
      _size = value;
    }
  }
  private uint? _size = 0;
}
