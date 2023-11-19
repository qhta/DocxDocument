using System;

namespace DocumentModel.VariantTypes;

/// <summary>
/// Clipboard Data variant. Value is of byte[] type. Has additional properties.
/// </summary>
public class VTClipboardData: Variant
{
  /// <summary>
  /// <para>Format Attribute</para>
  /// </summary>
  public Int32? Format { get; set; }

  /// <summary>
  /// <para>size</para>
  /// </summary>
  public UInt32? Size { get; set; }
}
