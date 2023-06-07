namespace ModelGen;
public class ElementDocumentation
{
  /// <summary>
  /// Documentation comments structure as read from code.
  /// </summary>
  public XElement? Documentation { get; set; }

  /// <summary>
  /// Metadata get from documentation.
  /// </summary>
  public Metadata? Metadata { get; set; }
}
