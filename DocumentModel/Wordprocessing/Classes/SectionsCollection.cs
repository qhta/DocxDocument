namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Collection of sections that should be rebuild after SectionProperties 
///   were added to or deleted from ParagraphProperties in any paragraph.
///   Also the last SectionProperties element in a Body defines the last section in this collection.
/// </summary>
public class SectionsCollection : LinkedList<Section>
{
  public static SectionsCollection Create(Body aBody)
  {
    var sections = new SectionsCollection();
    var lastSectionProperties = aBody.LastOrDefault() as SectionProperties;
    if (lastSectionProperties != null)
    {
      var section = new Section();
      section.Properties = lastSectionProperties;
      var index = section.FillBackward(aBody, aBody.Count() - 1);
      sections.AddFirst(section);
      while (index >= 0)
      {
        section = new Section();
        var aParagraph = aBody[index] as Paragraph;
        if (aParagraph != null)
        {
          section.Properties = aParagraph.ParagraphProperties?.SectionProperties;
          section.AddLast(aParagraph);
        }
        sections.AddFirst(section);
        if (index>0)
          index = section.FillBackward(aBody, index - 1);
        else
          break;
      }
    }
    return sections;
  }

  public void Add(Section section)
  {
    AddLast(section);
  }
}