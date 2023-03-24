namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   This class does not exists in wordprocessing document. 
///   In OpenXml sections are represented by SectionProperties elements only.
///   Each document body has one SectionProperties element at the end. This element represents properties of the last section of the document.
///   Other SectionProperties are contained in paragraphs and represent the properties of just ended sections.
/// </summary>
public class Section : LinkedList<IBodyElement>
{
  [XmlContentElement] public SectionProperties? Properties { get; set; }

  /// <summary>
  /// Inserts body elements from specified index backward to this section.
  /// Iterates until a paragraph with SectionProperties is found.
  /// </summary>
  /// <returns></returns>
  public int FillBackward(Body aBody, int index)
  {
    while (index >= 0 && index < aBody.Count)
    {
      var item = aBody[index];
      if (item is Paragraph paragraph && paragraph.ParagraphProperties?.SectionProperties!=null)
        break;
      AddFirst(item);
      index--;
    }
    return index;
  }

  public void Add(IBodyElement element)
  {
    AddLast(element);
  }
}