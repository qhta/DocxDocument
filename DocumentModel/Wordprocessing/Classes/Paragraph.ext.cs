namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the Paragraph Class.
/// </summary>
[JsonObject]
public partial class Paragraph: ICollection<ParagraphElement>
{
  [JsonProperty(Order = 1000)]
  private ElementCollection<ParagraphElement> Items = new ();

  public void Add(ParagraphElement item)
  {
    ((ICollection<ParagraphElement>)Items).Add(item);
  }

  public void Clear()
  {
    ((ICollection<ParagraphElement>)Items).Clear();
  }

  public bool Contains(ParagraphElement item)
  {
    return ((ICollection<ParagraphElement>)Items).Contains(item);
  }

  public void CopyTo(ParagraphElement[] array, int arrayIndex)
  {
    ((ICollection<ParagraphElement>)Items).CopyTo(array, arrayIndex);
  }

  public bool Remove(ParagraphElement item)
  {
    return ((ICollection<ParagraphElement>)Items).Remove(item);
  }

  [XmlIgnore]
  [JsonIgnore]
  public int Count => ((ICollection<ParagraphElement>)Items).Count;

  [XmlIgnore]
  [JsonIgnore]
  public bool IsReadOnly => ((ICollection<ParagraphElement>)Items).IsReadOnly;

  public IEnumerator<ParagraphElement> GetEnumerator()
  {
    return ((IEnumerable<ParagraphElement>)Items).GetEnumerator();
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)Items).GetEnumerator();
  }

}