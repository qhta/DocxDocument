namespace DocxDocument.Model;

public enum LimitLocation
{
  /// <summary>
  /// Under-Over location.
  /// <para>When the item is serialized out as xml, its value is "undOvr".</para>
  /// </summary>
  [XmlEnum("undOvr")]
  UnderOver,
  /// <summary>
  /// Subscript-Superscript location.
  /// <para>When the item is serialized out as xml, its value is "subSup".</para>
  /// </summary>
  [XmlEnum("subSup")]
  SubscriptSuperscript
}