namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an embedded object within a WordprocessingML document, such as an OLE object or other non-native content.
/// </summary>
/// <remarks>The EmbeddedObject class provides properties for specifying the original dimensions and anchor
/// identifier of the embedded object. The anchor identifier property is only available in Office 2010 and later
/// versions. This class is typically used when working with documents that include objects embedded from external
/// sources.</remarks>
[XmlRoot("EmbeddedObject", Namespace = "DocumentModel.Wordprocessing")]
[OpenXmlType(typeof(DXW.EmbeddedObject))]
public class EmbeddedObject: ModelElement<DXW.EmbeddedObject>
{
  /// <summary>
  /// <para>dxaOrig</para>
  /// </summary>
  [OpenXmlProperty("DxaOriginal")]
  public String? DxaOriginal { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// <para>dyaOrig</para>
  /// </summary>
  [OpenXmlProperty("DyaOriginal")]
  public String? DyaOriginal { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// <para>anchorId, this property is only available in Office 2010 and later.</para>
  /// </summary>
  [OpenXmlProperty("AnchorId")]
  public HexBinary? AnchorId { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }

}