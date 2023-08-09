namespace ModelGen;

/// <summary>
///   Docs Comments assigned to model element.
/// </summary>
public class ElementDocs : Collection<XElement>
{
  /// <summary>
  /// XElement representation of summary.
  /// </summary>
  [XmlIgnore]
  public XElement? Summary
  {
    get
    {
      return this.FirstOrDefault(item => item.Name == "summary");
    }
    set
    {
      var summary = Summary;
      if (summary != null)
        this.Remove(summary);
      if (value != null)
        this.Insert(0, value);
    }
  }

  public bool IsEmpty => Count == 0;

  public override string ToString()
  {
    return String.Join("\r\n", Items.Select(item => item.ToString()));
  }
}
